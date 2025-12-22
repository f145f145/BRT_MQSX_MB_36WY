/************************************************************************************
 * 描述：
 * 装置Model，主体部分
 * ==================================================================================
 * 修改标记
 * 修改时间				    修改人			版本号			描述
 * 2023-1-29 10:55:08		郝正强			V2.0.0.0        根据单风机参数重新修改
 ************************************************************************************/

using CtrlMethod;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using MQZHWL.BLL;
using System;
using System.Windows;
using System.Windows.Threading;

namespace MQZHWL.Model.DEV
{
    public partial class MQZH_DevModel_Main : ObservableObject
    {
        public MQZH_DevModel_Main()
        {
            GetComList();

            //虚拟压力初始化
            PressSet_QM_Init();

            PressSet_KFYDJ_Init();
            PressSet_KFYGC_Init();

            //订阅通讯数据更新消息
            Messenger.Default.Register<ushort[]>(this, "PLCDataUpdated", PLCDataUpdated);
            Messenger.Default.Register<ushort[]>(this, "THPDataUpdated", THPDataUpdated);

            //订阅错误信息提示消息
            Messenger.Default.Register<string>(this, "ComError1", ErrorMessage);
            //订阅错误信息提示消息
            Messenger.Default.Register<string>(this, "PIDinfoMessage", PIDinfoMessage);

            //自动调零消息
            Messenger.Default.Register<string>(this, "SetZeroMessage", SetZeroMessage);

            //错误信息复位定时器初始化
            ErrorResetTimer.Tick += new EventHandler(ErrorResetTimer_Tick);
            ErrorResetTimer.Interval = TimeSpan.FromSeconds(5);
            ErrorResetTimer.Start();
        }


        /// <summary>
        /// 水密喷淋水流量PID
        /// </summary>
        private PID_CtrlModel _pid_SMSLL = new PID_CtrlModel();
        /// <summary>
        /// 水密喷淋水流量PID
        /// </summary>
        public PID_CtrlModel PID_SMSLL
        {
            get { return _pid_SMSLL; }
            set
            {
                _pid_SMSLL = value;
                RaisePropertyChanged(() => PID_SMSLL);
            }
        }

        #region 故障信息及复位定时器

        /// <summary>
        /// 错误提示信息
        /// </summary>
        private string _errorInfo = "";
        /// <summary>
        /// 错误提示信息
        /// </summary>
        public string ErrorInfo
        {
            get { return _errorInfo; }
            set
            {
                _errorInfo = value;
                RaisePropertyChanged(() => ErrorInfo);
            }
        }

        /// <summary>
        /// pid输出数据显示标志
        /// </summary>
        private bool _isPIDInfoShow =false;
        /// <summary>
        /// pid输出数据显示标志
        /// </summary>
        public bool IsPIDInfoShow
        {
            get { return _isPIDInfoShow; }
            set
            {
                _isPIDInfoShow = value;
                RaisePropertyChanged(() => IsPIDInfoShow);
            }
        }

        /// <summary>
        /// pid输出数据提示信息
        /// </summary>
        private string _pidInfo = "";
        /// <summary>
        /// pid输出数据提示信息
        /// </summary>
        public string PIDInfo
        {
            get { return _pidInfo; }
            set
            {
                _pidInfo = value;
                RaisePropertyChanged(() => PIDInfo);
            }
        }

        /// <summary>
        /// 故障信息传递消息
        /// </summary>
        /// <param name="msg"></param>
        private void ErrorMessage(string msg)
        {
            ErrorInfo = msg;
        }

        /// <summary>
        /// PID控制输出传递消息
        /// </summary>
        /// <param name="msg"></param>
        private void PIDinfoMessage(string msg)
        {
            PIDInfo = msg;
        }

        /// <summary>
        /// 错误信息复位定时器
        /// </summary>
        readonly DispatcherTimer ErrorResetTimer = new DispatcherTimer();

        /// <summary>
        /// 错误信息复位定时器回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ErrorResetTimer_Tick(object sender, EventArgs e)
        {
            ErrorInfo = "";
        }

        #endregion


        #region 数据定时更新消息

        /// <summary>
        /// PLC采集数据更新消息处理
        /// </summary>
        /// <param name="msg"></param>
        private void PLCDataUpdated(ushort[] msg)
        {
            try
            {

                ushort[] inArry;
                inArry = (ushort[])msg.Clone();
                if (inArry.Length >= 64)
                {
                    bool[] boolValues1;
                    bool[] boolValues2;
                    bool[] boolValues3;
                    bool[] boolValues4;
                    bool[] boolValuesAll = new bool[64];
                    int[] transIntValues = new int[62];
                    ushort[] ffStatus = new ushort[13];

                    //解析状态---------------------------
                    //ushort解析为bool
                    boolValues1 = MQZH_ValueCvtBLL.GetBoolsFromUshort(inArry, 0, 1);
                    boolValues2 = MQZH_ValueCvtBLL.GetBoolsFromUshort(inArry, 1, 1);
                    boolValues3 = MQZH_ValueCvtBLL.GetBoolsFromUshort(inArry, 2, 1);
                    boolValues4 = MQZH_ValueCvtBLL.GetBoolsFromUshort(inArry, 3, 1);
                    Array.Copy(boolValues1, 0, boolValuesAll, 0, boolValues1.Length);
                    Array.Copy(boolValues2, 0, boolValuesAll, boolValues1.Length, boolValues2.Length);
                    Array.Copy(boolValues3, 0, boolValuesAll, (boolValues1.Length + boolValues2.Length), boolValues3.Length);
                    Array.Copy(boolValues4, 0, boolValuesAll, (boolValues1.Length + boolValues2.Length + boolValues3.Length), boolValues4.Length);

                    //更新PLC的DI通道状态
                    for (int i = 0; i < Mod_XNDI.Channels.Count; i++)
                    {
                        Mod_XNDI.Channels[i].IsOn = boolValuesAll[i];
                    }
                    //更新装置DI参数状态
                    for (int i = 0; i < DIList.Count; i++)
                    {
                        DIList[i].GetDIStatus();
                    }

                    //解析、PLC的AI通道传输值 ---------------------
                    //ushort解析为int
                    for (int i = 4; i < inArry.Length; i++)
                    {
                        transIntValues[i - 4] = MQZH_ValueCvtBLL.GetShortFromUshort(inArry, i);
                    }

                    //-----------临时测试
                    PressSet = transIntValues[60];
                    PressDQ = transIntValues[61];

                    //差压、风速         
                    Mod_AD4.Channels[0].DataRealTime = Convert.ToDouble(transIntValues[15]);
                    Mod_AD4.Channels[1].DataRealTime = Convert.ToDouble(transIntValues[17]);
                    Mod_AD4.Channels[2].DataRealTime = Convert.ToDouble(transIntValues[18]);
                    Mod_AD4.Channels[3].DataRealTime = Convert.ToDouble(transIntValues[19]);
                    //频率显示
                    Mod_DAView.Channels[0].DataRealTime = Convert.ToDouble(transIntValues[0]);
                    Mod_DAView.Channels[1].DataRealTime = Convert.ToDouble(transIntValues[1]);
                    //位移1-12
                    Mod_AD1.Channels[0].DataRealTime = Convert.ToDouble(transIntValues[24]);
                    Mod_AD1.Channels[1].DataRealTime = Convert.ToDouble(transIntValues[25]);
                    Mod_AD1.Channels[2].DataRealTime = Convert.ToDouble(transIntValues[26]);
                    Mod_AD1.Channels[3].DataRealTime = Convert.ToDouble(transIntValues[27]);
                    Mod_AD2.Channels[0].DataRealTime = Convert.ToDouble(transIntValues[28]);
                    Mod_AD2.Channels[1].DataRealTime = Convert.ToDouble(transIntValues[29]);
                    Mod_AD2.Channels[2].DataRealTime = Convert.ToDouble(transIntValues[30]);
                    Mod_AD2.Channels[3].DataRealTime = Convert.ToDouble(transIntValues[31]);
                    Mod_AD3.Channels[0].DataRealTime = Convert.ToDouble(transIntValues[32]);
                    Mod_AD3.Channels[1].DataRealTime = Convert.ToDouble(transIntValues[33]);
                    Mod_AD3.Channels[2].DataRealTime = Convert.ToDouble(transIntValues[34]);
                    Mod_AD3.Channels[3].DataRealTime = Convert.ToDouble(transIntValues[35]);
                    if (Is36WY)
                    {
                        //位移13-36
                        Mod_AD5.Channels[0].DataRealTime = Convert.ToDouble(transIntValues[36]);
                        Mod_AD5.Channels[1].DataRealTime = Convert.ToDouble(transIntValues[37]);
                        Mod_AD5.Channels[2].DataRealTime = Convert.ToDouble(transIntValues[38]);
                        Mod_AD5.Channels[3].DataRealTime = Convert.ToDouble(transIntValues[39]);
                        Mod_AD5.Channels[4].DataRealTime = Convert.ToDouble(transIntValues[40]);
                        Mod_AD5.Channels[5].DataRealTime = Convert.ToDouble(transIntValues[41]);

                        Mod_AD6.Channels[0].DataRealTime = Convert.ToDouble(transIntValues[42]);
                        Mod_AD6.Channels[1].DataRealTime = Convert.ToDouble(transIntValues[43]);
                        Mod_AD6.Channels[2].DataRealTime = Convert.ToDouble(transIntValues[44]);
                        Mod_AD6.Channels[3].DataRealTime = Convert.ToDouble(transIntValues[45]);
                        Mod_AD6.Channels[4].DataRealTime = Convert.ToDouble(transIntValues[46]);
                        Mod_AD6.Channels[5].DataRealTime = Convert.ToDouble(transIntValues[47]);

                        Mod_AD7.Channels[0].DataRealTime = Convert.ToDouble(transIntValues[48]);
                        Mod_AD7.Channels[1].DataRealTime = Convert.ToDouble(transIntValues[49]);
                        Mod_AD7.Channels[2].DataRealTime = Convert.ToDouble(transIntValues[50]);
                        Mod_AD7.Channels[3].DataRealTime = Convert.ToDouble(transIntValues[51]);
                        Mod_AD7.Channels[4].DataRealTime = Convert.ToDouble(transIntValues[52]);
                        Mod_AD7.Channels[5].DataRealTime = Convert.ToDouble(transIntValues[53]);

                        Mod_AD8.Channels[0].DataRealTime = Convert.ToDouble(transIntValues[54]);
                        Mod_AD8.Channels[1].DataRealTime = Convert.ToDouble(transIntValues[55]);
                        Mod_AD8.Channels[2].DataRealTime = Convert.ToDouble(transIntValues[56]);
                        Mod_AD8.Channels[3].DataRealTime = Convert.ToDouble(transIntValues[57]);
                        Mod_AD9.Channels[0].DataRealTime = Convert.ToDouble(transIntValues[58]);
                        Mod_AD9.Channels[1].DataRealTime = Convert.ToDouble(transIntValues[59]);
                        //管路温湿度
                        Mod_AD9.Channels[2].DataRealTime = Convert.ToDouble(transIntValues[22]);
                        Mod_AD9.Channels[3].DataRealTime = Convert.ToDouble(transIntValues[23]);
                    }

                    //更新PLC的AI参数
                    for (int i = 0; i < AIList.Count; i++)
                    {
                        if ((i <7) || (i > 9))
                            AIList[i].CalcAIValues();
                    }

                    //更新辅助参数
                    //风量
                    switch (FSNo_FG1)
                    {
                        case 1:
                            FL1 = AIList[3].ValueFinal * 3.14159 * GJ_FG1 * GJ_FG1 / 4000000 * 3600;
                            break;
                        case 2:
                            FL1 = AIList[4].ValueFinal * 3.14159 * GJ_FG1 * GJ_FG1 / 4000000 * 3600;
                            break;
                        case 3:
                            FL1 = AIList[5].ValueFinal * 3.14159 * GJ_FG1 * GJ_FG1 / 4000000 * 3600;
                            break;
                    }
                    switch (FSNo_FG2)
                    {
                        case 1:
                            FL2 = AIList[3].ValueFinal * 3.14159 * GJ_FG2 * GJ_FG2 / 4000000 * 3600;
                            break;
                        case 2:
                            FL2 = AIList[4].ValueFinal * 3.14159 * GJ_FG2 * GJ_FG2 / 4000000 * 3600;
                            break;
                        case 3:
                            FL2 = AIList[5].ValueFinal * 3.14159 * GJ_FG2 * GJ_FG2 / 4000000 * 3600;
                            break;
                    }
                    switch (FSNo_FG3)
                    {
                        case 1:
                            FL3 = AIList[3].ValueFinal * 3.14159 * GJ_FG3 * GJ_FG3 / 4000000 * 3600;
                            break;
                        case 2:
                            FL3 = AIList[4].ValueFinal * 3.14159 * GJ_FG3 * GJ_FG3 / 4000000 * 3600;
                            break;
                        case 3:
                            FL3 = AIList[5].ValueFinal * 3.14159 * GJ_FG3 * GJ_FG3 / 4000000 * 3600;
                            break;
                    }
                    //水流量
                    //   SLL = AIList[18].ValueFinal * 3.14159 * GJ_SG * GJ_SG / 4000000 * 3600;    //采集单位m/s
                    SLL = AIList[6].ValueFinal;    //采集单位m³/s

                    //各轴位移值
                    WYValueX = -AIList[WYNOList[0] + 13].ValueFinal;
                    WYValueY[0] = AIList[WYNOList[1] + 13].ValueFinal;
                    WYValueY[1] = AIList[WYNOList[2] + 13].ValueFinal;
                    WYValueY[2] = AIList[WYNOList[3] + 13].ValueFinal;
                    WYValueY[3] = -(AIList[WYNOList[1] + 13].ValueFinal + AIList[WYNOList[2] + 13].ValueFinal + AIList[WYNOList[3] + 13].ValueFinal) / 3;
                    WYValueZ[0] = AIList[WYNOList[4] + 13].ValueFinal;
                    WYValueZ[1] = AIList[WYNOList[5] + 13].ValueFinal;
                    WYValueZ[2] = AIList[WYNOList[6] + 13].ValueFinal;
                    WYValueZ[3] = (AIList[WYNOList[4] + 13].ValueFinal + AIList[WYNOList[5] + 13].ValueFinal + AIList[WYNOList[6] + 13].ValueFinal) / 3;

                    //外喷淋位移尺位移
                    WyWPL[0] = -AIList[14].ValueFinal;
                    WyWPL[1] = -AIList[15].ValueFinal;
                    WyWPL[2] = -AIList[16].ValueFinal;
                    WyWPL[3] = -AIList[17].ValueFinal;
                    WyWPL[4] = -AIList[18].ValueFinal;
                    WyWPL[5] = -AIList[19].ValueFinal;
                    WyWPL[6] = -AIList[20].ValueFinal;
                    WyWPL[7] = -AIList[21].ValueFinal;
                    WyWPL[8] = -AIList[22].ValueFinal;
                    WyWPL[9] = -AIList[23].ValueFinal;
                    WyWPL[10] = -AIList[24].ValueFinal;
                    WyWPL[11] = -AIList[25].ValueFinal;
                    WyWPL[12] = -AIList[26].ValueFinal;
                    WyWPL[13] = -AIList[27].ValueFinal;
                    WyWPL[14] = -AIList[28].ValueFinal;
                    WyWPL[15] = -AIList[29].ValueFinal;
                    WyWPL[16] = -AIList[30].ValueFinal;
                    WyWPL[17] = -AIList[31].ValueFinal;
                    WyWPL[18] = -AIList[32].ValueFinal;
                    WyWPL[19] = -AIList[33].ValueFinal;
                    WyWPL[20] = -AIList[34].ValueFinal;
                    WyWPL[21] = -AIList[35].ValueFinal;
                    WyWPL[22] = -AIList[36].ValueFinal;
                    WyWPL[23] = -AIList[37].ValueFinal;
                    WyWPL[24] = -AIList[38].ValueFinal;
                    WyWPL[25] = -AIList[39].ValueFinal;
                    WyWPL[26] = -AIList[40].ValueFinal;
                    WyWPL[27] = -AIList[41].ValueFinal;
                    WyWPL[28] = -AIList[42].ValueFinal;
                    WyWPL[29] = -AIList[43].ValueFinal;
                    WyWPL[30] = -AIList[44].ValueFinal;
                    WyWPL[31] = -AIList[45].ValueFinal;
                    WyWPL[32] = -AIList[46].ValueFinal;
                    WyWPL[33] = -AIList[47].ValueFinal;
                    WyWPL[34] = -AIList[48].ValueFinal;
                    WyWPL[35] = -AIList[49].ValueFinal;

                    //解析换向阀状态
                    //ushort解析为int
                    Array.Copy(msg, 6, ffStatus, 0, 13);
                    Valve.StatusUpdate(ffStatus);


                 //   Messenger.Default.Send<string>("AD1-1:" + Mod_AD1.Channels[0].DataRealTime.ToString()+",FV:"+ AIList[14].ValueFinal.ToString(), "ComError1");
                }
                Messenger.Default.Send<string>("UpdateChart", "UpdateChart");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        /// <summary>
        ///三合一数据更新消息处理
        /// </summary>
        /// <param name="msg"></param>
        private void THPDataUpdated(ushort[] msg)
        {
            ushort[] inArry;
            inArry = (ushort[])msg.Clone();
            if (inArry.Length >= 3)
            {
                //解析结果存储区
                int[] transIntValues = new int[inArry.Length];

                //ushort解析，更新三合一模块通道传输值
                transIntValues[0] = ValueCvt.GetShortFromUshort(inArry, 0);
                transIntValues[1] = ValueCvt.GetShortFromUshort(inArry, 1);
                transIntValues[2] = ValueCvt.GetShortFromUshort(inArry, 2);
                Mod_THP.Channels[0].DataRealTime = transIntValues[0];
                Mod_THP.Channels[1].DataRealTime = transIntValues[1];
                Mod_THP.Channels[2].DataRealTime = transIntValues[2];
                //更新三合一参数
                AIList[7].CalcAIValues();
                AIList[8].CalcAIValues();
                AIList[9].CalcAIValues();
            }
            Messenger.Default.Send<string>("THP", "AioDioUpdated");
        }
        #endregion

    }
}