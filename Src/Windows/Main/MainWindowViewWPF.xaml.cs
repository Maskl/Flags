﻿using Flags.MVVMUtils;

namespace Flags
{
    public partial class MainWindowViewWPF
    {
        public MainWindowViewWPF()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}