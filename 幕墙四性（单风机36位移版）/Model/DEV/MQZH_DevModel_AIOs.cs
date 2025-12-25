/************************************************************************************
 * 创建人：  郝正强
 * 电子邮箱：88129312@qq.com
 * 描述：
 *
 * ==================================================================================
 * 修改标记
 * 修改时间				    修改人			版本号			描述
 * 2022-05-26 10:54:56		郝正强			V1.0.0.0
 * 2024-01-03 15:54:00		郝正强			V2.0.0.0        改为单风机版
 ************************************************************************************/

using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace MQZHWL.Model.DEV
{
    public partial class MQZH_DevModel_Main : ObservableObject
    {
        #region 模拟量模块

        /// <summary>
        /// AD模块1
        /// </summary>
        private AnalogModuleModel _mod_AD1 = new AnalogModuleModel()
        {
            ModuleNO = "AD-1",
            ModuleName = "AD模块1",
            Channels = new ObservableCollection<AnalogChannelModel>()
            {
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel()
            }
        };

        /// <summary>
        /// AD模块1
        /// </summary>
        public AnalogModuleModel Mod_AD1
        {
            get { return _mod_AD1; }
            set
            {
                _mod_AD1 = value;
                RaisePropertyChanged(() => Mod_AD1);
            }
        }

        /// <summary>
        /// AD模块2
        /// </summary>
        private AnalogModuleModel _mod_AD2 = new AnalogModuleModel()
        {
            ModuleNO = "AD-2",
            ModuleName = "AD模块2",
            Channels = new ObservableCollection<AnalogChannelModel>()
            {
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel()
            }
        };
        /// <summary>
        /// AD模块2
        /// </summary>
        public AnalogModuleModel Mod_AD2
        {
            get { return _mod_AD2; }
            set
            {
                _mod_AD2 = value;
                RaisePropertyChanged(() => Mod_AD2);
            }
        }

        /// <summary>
        /// AD模块3
        /// </summary>
        private AnalogModuleModel _mod_AD3 = new AnalogModuleModel()
        {
            ModuleNO = "AD-3",
            ModuleName = "AD模块3",
            Channels = new ObservableCollection<AnalogChannelModel>()
            {
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel()
            }
        };
        /// <summary>
        /// AD模块3
        /// </summary>
        public AnalogModuleModel Mod_AD3
        {
            get { return _mod_AD3; }
            set
            {
                _mod_AD3 = value;
                RaisePropertyChanged(() => Mod_AD3);
            }
        }

        /// <summary>
        /// AD模块4
        /// </summary>
        private AnalogModuleModel _mod_AD4 = new AnalogModuleModel()
        {
            ModuleNO = "AD-4",
            ModuleName = "AD模块4",
            Channels = new ObservableCollection<AnalogChannelModel>()
            {
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel()
            }
        };
        /// <summary>
        /// AD模块4
        /// </summary>
        public AnalogModuleModel Mod_AD4
        {
            get { return _mod_AD4; }
            set
            {
                _mod_AD4 = value;
                RaisePropertyChanged(() => Mod_AD4);
            }
        }

        /// <summary>
        /// AD模块5
        /// </summary>
        private AnalogModuleModel _mod_AD5 = new AnalogModuleModel()
        {
            ModuleNO = "AD-5",
            ModuleName = "AD模块5",
            Channels = new ObservableCollection<AnalogChannelModel>()
            {
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel()
            }
        };
        /// <summary>
        /// AD模块5
        /// </summary>
        public AnalogModuleModel Mod_AD5
        {
            get { return _mod_AD5; }
            set
            {
                _mod_AD5 = value;
                RaisePropertyChanged(() => Mod_AD5);
            }
        }

        /// <summary>
        /// AD模块6
        /// </summary>
        private AnalogModuleModel _mod_AD6 = new AnalogModuleModel()
        {
            ModuleNO = "AD-6",
            ModuleName = "AD模块6",
            Channels = new ObservableCollection<AnalogChannelModel>()
            {
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel()
            }
        };
        /// <summary>
        /// AD模块6
        /// </summary>
        public AnalogModuleModel Mod_AD6
        {
            get { return _mod_AD6; }
            set
            {
                _mod_AD6 = value;
                RaisePropertyChanged(() => Mod_AD6);
            }
        }

        /// <summary>
        /// AD模块7
        /// </summary>
        private AnalogModuleModel _mod_AD7 = new AnalogModuleModel()
        {
            ModuleNO = "AD-7",
            ModuleName = "AD模块7",
            Channels = new ObservableCollection<AnalogChannelModel>()
            {
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel()
            }
        };
        /// <summary>
        /// AD模块7
        /// </summary>
        public AnalogModuleModel Mod_AD7
        {
            get { return _mod_AD7; }
            set
            {
                _mod_AD7 = value;
                RaisePropertyChanged(() => Mod_AD7);
            }
        }

        /// <summary>
        /// AD模块8
        /// </summary>
        private AnalogModuleModel _mod_AD8 = new AnalogModuleModel()
        {
            ModuleNO = "AD-8",
            ModuleName = "AD模块8",
            Channels = new ObservableCollection<AnalogChannelModel>()
            {
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel()
            }
        };
        /// <summary>
        /// AD模块8
        /// </summary>
        public AnalogModuleModel Mod_AD8
        {
            get { return _mod_AD8; }
            set
            {
                _mod_AD8 = value;
                RaisePropertyChanged(() => Mod_AD8);
            }
        }


        /// <summary>
        /// AD模块9
        /// </summary>
        private AnalogModuleModel _mod_AD9 = new AnalogModuleModel()
        {
            ModuleNO = "AD-9",
            ModuleName = "AD模块9",
            Channels = new ObservableCollection<AnalogChannelModel>()
            {
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel()
            }
        };
        /// <summary>
        /// AD模块9
        /// </summary>
        public AnalogModuleModel Mod_AD9
        {
            get { return _mod_AD9; }
            set
            {
                _mod_AD9 = value;
                RaisePropertyChanged(() => Mod_AD9);
            }
        }


        /// <summary>
        /// 频率显示
        /// </summary>
        private AnalogModuleModel _mod_DAView = new AnalogModuleModel()
        {
            ModuleNO = "DAView",
            ModuleName = "DAView",
            Channels = new ObservableCollection<AnalogChannelModel>()
            {
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel()
            }
        };
        /// <summary>
        /// 频率显示
        /// </summary>
        public AnalogModuleModel Mod_DAView
        {
            get { return _mod_DAView; }
            set
            {
                _mod_DAView = value;
                RaisePropertyChanged(() => Mod_DAView);
            }
        }

        /// <summary>
        /// DA模块
        /// </summary>
        private AnalogModuleModel _mod_DA = new AnalogModuleModel()
        {
            ModuleNO = "DA-1",
            ModuleName = "DA模块1",
            Channels = new ObservableCollection<AnalogChannelModel>()
            {
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel()
            }
        };
        /// <summary>
        /// DA模块
        /// </summary>
        public AnalogModuleModel Mod_DA
        {
            get { return _mod_DA; }
            set
            {
                _mod_DA = value;
                RaisePropertyChanged(() => Mod_DA);
            }
        }
        
        /// <summary>
        /// 三合一传感器
        /// </summary>
        private AnalogModuleModel _mod_THP = new AnalogModuleModel()
        {
            ModuleNO = "THP",
            ModuleName = "三合一传感器",
            Channels = new ObservableCollection<AnalogChannelModel>()
            {
                new AnalogChannelModel(),
                new AnalogChannelModel(),
                new AnalogChannelModel()
            }
        };
        /// <summary>
        /// 三合一传感器
        /// </summary>
        public AnalogModuleModel Mod_THP
        {
            get { return _mod_THP; }
            set
            {
                _mod_THP = value;
                RaisePropertyChanged(() => Mod_THP);
            }
        }

        #endregion


        #region 模拟量参数

        /// <summary>
        /// 模拟量输入参数列表（01小差压、02中压差、03大差压、04风速1、05风速2、06风速3、07水流速、
        /// 08环境温度、09环境湿度、10大气压力、11风机频率显示、12水泵频率显示、13管路温度、14管路湿度、
        /// 15位移尺1、16位移尺2、17位移尺3、18位移尺4、19位移尺5、20位移尺6、21位移尺7、22位移尺8、23位移尺9、24位移尺10、25位移尺11、26位移尺12、
        /// 27位移尺13、28位移尺14、29位移尺15、30位移尺16、31位移尺17、32位移尺18、33位移尺19、34位移尺20、35位移尺21、36位移尺22、37位移尺23、38位移尺24、
        /// 39位移尺25、40位移尺26、41位移尺27、42位移尺28、43位移尺29、44位移尺30、45位移尺31、46位移尺32、47位移尺33、48位移尺34、49位移尺35、50位移尺36、）
        /// </summary>
        private ObservableCollection<AnalogModel> _aiList = new ObservableCollection<AnalogModel>()
        {
            new AnalogModel(), new AnalogModel(), new AnalogModel(), new AnalogModel(),new AnalogModel(), new AnalogModel(), new AnalogModel(), new AnalogModel(),new AnalogModel(), new AnalogModel(),
            new AnalogModel(), new AnalogModel(), new AnalogModel(), new AnalogModel(),new AnalogModel(), new AnalogModel(), new AnalogModel(), new AnalogModel(),new AnalogModel(), new AnalogModel(),
            new AnalogModel(), new AnalogModel(), new AnalogModel(), new AnalogModel(),new AnalogModel(), new AnalogModel(), new AnalogModel(), new AnalogModel(),new AnalogModel(), new AnalogModel(),
            new AnalogModel(), new AnalogModel(), new AnalogModel(), new AnalogModel(),new AnalogModel(), new AnalogModel(), new AnalogModel(), new AnalogModel(),new AnalogModel(), new AnalogModel(),
            new AnalogModel(), new AnalogModel(), new AnalogModel(), new AnalogModel(),new AnalogModel(), new AnalogModel(), new AnalogModel(), new AnalogModel(),new AnalogModel(), new AnalogModel()
        };
        /// <summary>
        /// 模拟量输入参数列表（01小差压、02中压差、03大差压、04风速1、05风速2、06风速3、07水流速、
        /// 08环境温度、09环境湿度、10大气压力、11风机频率显示、12水泵频率显示、13管路温度、14管路湿度、
        /// 15位移尺1、16位移尺2、17位移尺3、18位移尺4、19位移尺5、20位移尺6、21位移尺7、22位移尺8、23位移尺9、24位移尺10、25位移尺11、26位移尺12、
        /// 27位移尺13、28位移尺14、29位移尺15、30位移尺16、31位移尺17、32位移尺18、33位移尺19、34位移尺20、35位移尺21、36位移尺22、37位移尺23、38位移尺24、
        /// 39位移尺25、40位移尺26、41位移尺27、42位移尺28、43位移尺29、44位移尺30、45位移尺31、46位移尺32、47位移尺33、48位移尺34、49位移尺35、50位移尺36、）
        /// </summary>
        public ObservableCollection<AnalogModel> AIList
        {
            get { return _aiList; }
            set
            {
                _aiList = value;
                RaisePropertyChanged(() => AIList);
            }
        }

        /// <summary>
        /// 模拟量输出参数列表（风机频率、水泵频率）
        /// </summary>
        private ObservableCollection<AnalogModel> _aoList = new ObservableCollection<AnalogModel>()
        {
            new AnalogModel(),
            new AnalogModel()
        };
        /// <summary>
        /// 模拟量输出参数列表（风机频率、水泵频率）
        /// </summary>
        public ObservableCollection<AnalogModel> AOList
        {
            get { return _aoList; }
            set
            {
                _aoList = value;
                RaisePropertyChanged(() => AOList);
            }
        }

        #endregion


        #region 辅助参数
        
        /// <summary>
        /// 风量1
        /// </summary>
        private double _fl1 = 0;
        /// <summary>
        /// 风量1
        /// </summary>
        public double FL1
        {
            get { return _fl1;}
            set
            {
                _fl1 = value;
                RaisePropertyChanged(() => FL1);
            }
        }

        /// <summary>
        /// 风量2
        /// </summary>
        private double _fl2 = 0;
        /// <summary>
        /// 风量2
        /// </summary>
        public double FL2
        {
            get { return _fl2; }
            set
            {
                _fl2 = value;
                RaisePropertyChanged(() => FL2);
            }
        }

        /// <summary>
        /// 风量3
        /// </summary>
        private double _fl3 = 0;
        /// <summary>
        /// 风量3
        /// </summary>
        public double FL3
        {
            get { return _fl3; }
            set
            {
                _fl3 = value;
                RaisePropertyChanged(() => FL3);
            }
        }

        /// <summary>
        /// 水流量
        /// </summary>
        private double _sll = 0;
        /// <summary>
        /// 水流量
        /// </summary>
        public double SLL
        {
            get { return _sll; }
            set
            {
                _sll = value;
                RaisePropertyChanged(() => SLL);
            }
        }

        /// <summary>
        /// X轴位移值
        /// </summary>
        private double _wyValueX = 0;
        /// <summary>
        /// X轴位移值
        /// </summary>
        public double WYValueX
        {
            get { return _wyValueX; }
            set
            {
                _wyValueX = value;
                RaisePropertyChanged(() => WYValueX);
            }
        }

        /// <summary>
        /// Y轴位移值（左、中、右、平均）
        /// </summary>
        private ObservableCollection<double> _wyValueY = new ObservableCollection<double>(){0,0,0,0};
        /// <summary>
        /// Y轴位移值（左、中、右、平均）
        /// </summary>
        public ObservableCollection<double> WYValueY
        {
            get { return _wyValueY; }
            set
            {
                _wyValueY = value;
                RaisePropertyChanged(() => WYValueY);
            }
        }

        /// <summary>
        /// z轴位移值（左、中、右、平均）
        /// </summary>
        private ObservableCollection<double> _wyValueZ = new ObservableCollection<double>() { 0, 0, 0, 0 };
        /// <summary>
        /// z轴位移值（左、中、右、平均）
        /// </summary>
        public ObservableCollection<double> WYValueZ
        {
            get { return _wyValueZ; }
            set
            {
                _wyValueZ = value;
                RaisePropertyChanged(() => WYValueZ);
            }
        }

        #endregion


        #region 调零

        /// <summary>
        ///  模拟量自动调零。y=k*x+b，b=y0-k*x0
        /// </summary>
        private void SetZeroMessage(string msg)
        {
            string order = msg.Clone().ToString();
            if (order == "WYall")
            {
                AIList[14].ZeroCalValue = 0 - AIList[14].ValueCaledNonZero * AIList[14].KCalValue;
                AIList[15].ZeroCalValue = 0 - AIList[15].ValueCaledNonZero * AIList[15].KCalValue;
                AIList[16].ZeroCalValue = 0 - AIList[16].ValueCaledNonZero * AIList[16].KCalValue;
                AIList[17].ZeroCalValue = 0 - AIList[17].ValueCaledNonZero * AIList[17].KCalValue;
                AIList[18].ZeroCalValue = 0 - AIList[18].ValueCaledNonZero * AIList[18].KCalValue;
                AIList[19].ZeroCalValue = 0 - AIList[19].ValueCaledNonZero * AIList[19].KCalValue;
                AIList[20].ZeroCalValue = 0 - AIList[20].ValueCaledNonZero * AIList[20].KCalValue;
                AIList[21].ZeroCalValue = 0 - AIList[21].ValueCaledNonZero * AIList[21].KCalValue;
                AIList[22].ZeroCalValue = 0 - AIList[22].ValueCaledNonZero * AIList[22].KCalValue;
                AIList[23].ZeroCalValue = 0 - AIList[23].ValueCaledNonZero * AIList[23].KCalValue;
                AIList[24].ZeroCalValue = 0 - AIList[24].ValueCaledNonZero * AIList[24].KCalValue;
                AIList[25].ZeroCalValue = 0 - AIList[25].ValueCaledNonZero * AIList[25].KCalValue;
                AIList[26].ZeroCalValue = 0 - AIList[26].ValueCaledNonZero * AIList[26].KCalValue;
                AIList[27].ZeroCalValue = 0 - AIList[27].ValueCaledNonZero * AIList[27].KCalValue;
                AIList[28].ZeroCalValue = 0 - AIList[28].ValueCaledNonZero * AIList[28].KCalValue;
                AIList[29].ZeroCalValue = 0 - AIList[29].ValueCaledNonZero * AIList[29].KCalValue;
                AIList[30].ZeroCalValue = 0 - AIList[30].ValueCaledNonZero * AIList[30].KCalValue;
                AIList[31].ZeroCalValue = 0 - AIList[31].ValueCaledNonZero * AIList[31].KCalValue;
                AIList[32].ZeroCalValue = 0 - AIList[32].ValueCaledNonZero * AIList[32].KCalValue;
                AIList[33].ZeroCalValue = 0 - AIList[33].ValueCaledNonZero * AIList[33].KCalValue;
                AIList[34].ZeroCalValue = 0 - AIList[34].ValueCaledNonZero * AIList[34].KCalValue;
                AIList[35].ZeroCalValue = 0 - AIList[35].ValueCaledNonZero * AIList[35].KCalValue;
                AIList[36].ZeroCalValue = 0 - AIList[36].ValueCaledNonZero * AIList[36].KCalValue;
                AIList[37].ZeroCalValue = 0 - AIList[37].ValueCaledNonZero * AIList[37].KCalValue;
                AIList[38].ZeroCalValue = 0 - AIList[38].ValueCaledNonZero * AIList[38].KCalValue;
                AIList[39].ZeroCalValue = 0 - AIList[39].ValueCaledNonZero * AIList[39].KCalValue;
                AIList[40].ZeroCalValue = 0 - AIList[40].ValueCaledNonZero * AIList[40].KCalValue;
                AIList[41].ZeroCalValue = 0 - AIList[41].ValueCaledNonZero * AIList[41].KCalValue;
                AIList[42].ZeroCalValue = 0 - AIList[42].ValueCaledNonZero * AIList[42].KCalValue;
                AIList[43].ZeroCalValue = 0 - AIList[43].ValueCaledNonZero * AIList[43].KCalValue;
                AIList[44].ZeroCalValue = 0 - AIList[44].ValueCaledNonZero * AIList[44].KCalValue;
                AIList[45].ZeroCalValue = 0 - AIList[45].ValueCaledNonZero * AIList[45].KCalValue;
                AIList[46].ZeroCalValue = 0 - AIList[46].ValueCaledNonZero * AIList[46].KCalValue;
                AIList[47].ZeroCalValue = 0 - AIList[47].ValueCaledNonZero * AIList[47].KCalValue;
                AIList[48].ZeroCalValue = 0 - AIList[48].ValueCaledNonZero * AIList[48].KCalValue;
                AIList[49].ZeroCalValue = 0 - AIList[49].ValueCaledNonZero * AIList[49].KCalValue;
            }

            else if (order == "WY01")
            {
                AIList[14].ZeroCalValue = 0 - AIList[14].ValueCaledNonZero * AIList[14].KCalValue;
            }
            else if (order == "WY02")
            {
                AIList[15].ZeroCalValue = 0 - AIList[15].ValueCaledNonZero * AIList[15].KCalValue;
            }

            else if (order == "WY03")
            {
                AIList[16].ZeroCalValue = 0 - AIList[16].ValueCaledNonZero * AIList[16].KCalValue;
            }
            else if (order == "WY04")
            {
                AIList[17].ZeroCalValue = 0 - AIList[17].ValueCaledNonZero * AIList[17].KCalValue;
            }
            else if (order == "WY05")
            {
                AIList[18].ZeroCalValue = 0 - AIList[18].ValueCaledNonZero * AIList[18].KCalValue;
            }
            else if (order == "WY06")
            {
                AIList[19].ZeroCalValue = 0 - AIList[19].ValueCaledNonZero * AIList[19].KCalValue;
            }
            else if (order == "WY07")
            {
                AIList[20].ZeroCalValue = 0 - AIList[20].ValueCaledNonZero * AIList[20].KCalValue;
            }
            else if (order == "WY08")
            {
                AIList[21].ZeroCalValue = 0 - AIList[21].ValueCaledNonZero * AIList[21].KCalValue;
            }
            else if (order == "WY09")
            {
                AIList[22].ZeroCalValue = 0 - AIList[22].ValueCaledNonZero * AIList[22].KCalValue;
            }
            else if (order == "WY10")
            {
                AIList[23].ZeroCalValue = 0 - AIList[23].ValueCaledNonZero * AIList[23].KCalValue;
            }
            else if (order == "WY11")
            {
                AIList[24].ZeroCalValue = 0 - AIList[24].ValueCaledNonZero * AIList[24].KCalValue;
            }
            else if (order == "WY12")
            {
                AIList[25].ZeroCalValue = 0 - AIList[25].ValueCaledNonZero * AIList[25].KCalValue;
            }

            else if (order == "WY13")
            {
                AIList[26].ZeroCalValue = 0 - AIList[26].ValueCaledNonZero * AIList[26].KCalValue;
            }
            else if (order == "WY14")
            {
                AIList[27].ZeroCalValue = 0 - AIList[27].ValueCaledNonZero * AIList[27].KCalValue;
            }

            else if (order == "WY15")
            {
                AIList[28].ZeroCalValue = 0 - AIList[28].ValueCaledNonZero * AIList[28].KCalValue;
            }
            else if (order == "WY16")
            {
                AIList[29].ZeroCalValue = 0 - AIList[29].ValueCaledNonZero * AIList[29].KCalValue;
            }
            else if (order == "WY17")
            {
                AIList[30].ZeroCalValue = 0 - AIList[30].ValueCaledNonZero * AIList[30].KCalValue;
            }
            else if (order == "WY18")
            {
                AIList[31].ZeroCalValue = 0 - AIList[31].ValueCaledNonZero * AIList[31].KCalValue;
            }
            else if (order == "WY19")
            {
                AIList[32].ZeroCalValue = 0 - AIList[32].ValueCaledNonZero * AIList[32].KCalValue;
            }
            else if (order == "WY20")
            {
                AIList[33].ZeroCalValue = 0 - AIList[33].ValueCaledNonZero * AIList[33].KCalValue;
            }
            else if (order == "WY21")
            {
                AIList[34].ZeroCalValue = 0 - AIList[34].ValueCaledNonZero * AIList[34].KCalValue;
            }
            else if (order == "WY22")
            {
                AIList[35].ZeroCalValue = 0 - AIList[35].ValueCaledNonZero * AIList[35].KCalValue;
            }
            else if (order == "WY23")
            {
                AIList[36].ZeroCalValue = 0 - AIList[36].ValueCaledNonZero * AIList[36].KCalValue;
            }
            else if (order == "WY24")
            {
                AIList[37].ZeroCalValue = 0 - AIList[37].ValueCaledNonZero * AIList[37].KCalValue;
            }


            else if (order == "WY25")
            {
                AIList[38].ZeroCalValue = 0 - AIList[38].ValueCaledNonZero * AIList[38].KCalValue;
            }
            else if (order == "WY26")
            {
                AIList[39].ZeroCalValue = 0 - AIList[39].ValueCaledNonZero * AIList[39].KCalValue;
            }

            else if (order == "WY27")
            {
                AIList[40].ZeroCalValue = 0 - AIList[40].ValueCaledNonZero * AIList[40].KCalValue;
            }
            else if (order == "WY28")
            {
                AIList[41].ZeroCalValue = 0 - AIList[41].ValueCaledNonZero * AIList[41].KCalValue;
            }
            else if (order == "WY29")
            {
                AIList[42].ZeroCalValue = 0 - AIList[42].ValueCaledNonZero * AIList[42].KCalValue;
            }
            else if (order == "WY30")
            {
                AIList[43].ZeroCalValue = 0 - AIList[43].ValueCaledNonZero * AIList[43].KCalValue;
            }
            else if (order == "WY31")
            {
                AIList[44].ZeroCalValue = 0 - AIList[44].ValueCaledNonZero * AIList[44].KCalValue;
            }
            else if (order == "WY32")
            {
                AIList[45].ZeroCalValue = 0 - AIList[45].ValueCaledNonZero * AIList[45].KCalValue;
            }
            else if (order == "WY33")
            {
                AIList[46].ZeroCalValue = 0 - AIList[46].ValueCaledNonZero * AIList[46].KCalValue;
            }
            else if (order == "WY34")
            {
                AIList[47].ZeroCalValue = 0 - AIList[47].ValueCaledNonZero * AIList[47].KCalValue;
            }
            else if (order == "WY35")
            {
                AIList[48].ZeroCalValue = 0 - AIList[48].ValueCaledNonZero * AIList[48].KCalValue;
            }
            else if (order == "WY36")
            {
                AIList[49].ZeroCalValue = 0 - AIList[49].ValueCaledNonZero * AIList[49].KCalValue;
            }

            else if (order == "GW")
            {
                AIList[12].ZeroCalValue = 0 - AIList[12].ValueCaledNonZero * AIList[12].KCalValue;
            }
            else if (order == "GS")
            {
                AIList[13].ZeroCalValue = 0 - AIList[13].ValueCaledNonZero * AIList[13].KCalValue;
            }

            else if (order == "CY01")
            {
                AIList[0].ZeroCalValue = 0 - AIList[0].ValueCaledNonZero * AIList[0].KCalValue;
            }
            else if (order == "CY02")
            {
                AIList[1].ZeroCalValue = 0 - AIList[1].ValueCaledNonZero * AIList[1].KCalValue;
            }
            else if (order == "CY03")
            {
                AIList[2].ZeroCalValue = 0 - AIList[2].ValueCaledNonZero * AIList[2].KCalValue;
            }

            else if (order == "FS01")
            {
                AIList[3].ZeroCalValue = 0 - AIList[3].ValueCaledNonZero * AIList[3].KCalValue;
            }
            else if (order == "FS02")
            {
                AIList[4].ZeroCalValue = 0 - AIList[4].ValueCaledNonZero * AIList[4].KCalValue;
            }
            else if (order == "FS03")
            {
                AIList[5].ZeroCalValue = 0 - AIList[5].ValueCaledNonZero * AIList[5].KCalValue;
            }
            else if (order == "SLS")
            {
                AIList[6].ZeroCalValue = 0 - AIList[6].ValueCaledNonZero * AIList[6].KCalValue;
            }

            else if (order == "X")
            {
                AIList[WYNOList[0] + 13].ZeroCalValue = 0 - AIList[WYNOList[0] + 13].ValueCaledNonZero * AIList[WYNOList[0] + 13].KCalValue;
            }
            else if (order == "Y")
            {
                AIList[WYNOList[1] + 13].ZeroCalValue = 0 - AIList[WYNOList[1] + 13].ValueCaledNonZero * AIList[WYNOList[1] + 13].KCalValue;
                AIList[WYNOList[2] + 13].ZeroCalValue = 0 - AIList[WYNOList[2] + 13].ValueCaledNonZero * AIList[WYNOList[2] + 13].KCalValue;
                AIList[WYNOList[3] + 13].ZeroCalValue = 0 - AIList[WYNOList[3] + 13].ValueCaledNonZero * AIList[WYNOList[3] + 13].KCalValue;
            }
            else if (order == "Z")
            {
                AIList[WYNOList[4] + 13].ZeroCalValue = 0 - AIList[WYNOList[4] + 13].ValueCaledNonZero * AIList[WYNOList[4] + 13].KCalValue;
                AIList[WYNOList[5] + 13].ZeroCalValue = 0 - AIList[WYNOList[5] + 13].ValueCaledNonZero * AIList[WYNOList[5] + 13].KCalValue;
                AIList[WYNOList[6] + 13].ZeroCalValue = 0 - AIList[WYNOList[6] + 13].ValueCaledNonZero * AIList[WYNOList[6] + 13].KCalValue;
            }
            else if (order == "XYZ")
            {
                AIList[WYNOList[0] + 13].ZeroCalValue = 0 - AIList[WYNOList[0] + 13].ValueCaledNonZero * AIList[WYNOList[0] + 13].KCalValue;
                AIList[WYNOList[1] + 13].ZeroCalValue = 0 - AIList[WYNOList[1] + 13].ValueCaledNonZero * AIList[WYNOList[1] + 13].KCalValue;
                AIList[WYNOList[2] + 13].ZeroCalValue = 0 - AIList[WYNOList[2] + 13].ValueCaledNonZero * AIList[WYNOList[2] + 13].KCalValue;
                AIList[WYNOList[3] + 13].ZeroCalValue = 0 - AIList[WYNOList[3] + 13].ValueCaledNonZero * AIList[WYNOList[3] + 13].KCalValue;
                AIList[WYNOList[4] + 13].ZeroCalValue = 0 - AIList[WYNOList[4] + 13].ValueCaledNonZero * AIList[WYNOList[4] + 13].KCalValue;
                AIList[WYNOList[5] + 13].ZeroCalValue = 0 - AIList[WYNOList[5] + 13].ValueCaledNonZero * AIList[WYNOList[5] + 13].KCalValue;
                AIList[WYNOList[6] + 13].ZeroCalValue = 0 - AIList[WYNOList[6] + 13].ValueCaledNonZero * AIList[WYNOList[6] + 13].KCalValue;
            }
        }

        #endregion


        #region 下拉列表项

        /// <summary>
        /// 接口类型列表
        /// </summary>
        public ObservableCollection<string> _infTypeList = new ObservableCollection<string>() { "Voltage", "Current", "Digital", "Couple" };
        /// <summary>
        /// 接口类型列表
        /// </summary>
        public ObservableCollection<string> InfTypeList
        {
            get { return _infTypeList; }
        }

        /// <summary>
        /// 电信号单位列表
        /// </summary>
        public ObservableCollection<string> _elecSigUnitList = new ObservableCollection<string>() { "mA", "A", "V", "mV" };
        /// <summary>
        /// 标定点启用标志
        /// </summary>
        public ObservableCollection<string> ElecSigUnitList
        {
            get { return _elecSigUnitList; }
        }

        #endregion

    }
}