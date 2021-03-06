﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace Flags.MVVMUtils
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<ICountrySelector, CountrySelectorDebug>();
            }
            else
            {
                SimpleIoc.Default.Register<ICountrySelector, CountrySelector>();
            }

            SimpleIoc.Default.Register<MainWindowViewModel>();
            SimpleIoc.Default.Register<ResultsWindowViewModel>();
            SimpleIoc.Default.Register<CountriesListWindowViewModel>();
            SimpleIoc.Default.Register<CountryDetailsWindowViewModel>();
            SimpleIoc.Default.Register<HelpWindowViewModel>();
            SimpleIoc.Default.Register<HistoryWindowViewModel>();
            SimpleIoc.Default.Register<MenuWindowViewModel>();

            SimpleIoc.Default.Register<ViewManager>();
        }

        public MainWindowViewModel MainWindowVm
        {
            get { return ServiceLocator.Current.GetInstance<MainWindowViewModel>(); }
        }

        public ResultsWindowViewModel ResultsWindowVm
        {
            get { return ServiceLocator.Current.GetInstance<ResultsWindowViewModel>(); }
        }

        public CountriesListWindowViewModel CountriesListWindowVm
        {
            get { return ServiceLocator.Current.GetInstance<CountriesListWindowViewModel>(); }
        }

        public CountryDetailsWindowViewModel CountryDetailsWindowVm
        {
            get { return ServiceLocator.Current.GetInstance<CountryDetailsWindowViewModel>(); }
        }

        public HelpWindowViewModel HelpWindowVm
        {
            get { return ServiceLocator.Current.GetInstance<HelpWindowViewModel>(); }
        }

        public HistoryWindowViewModel HistoryWindowVm
        {
            get { return ServiceLocator.Current.GetInstance<HistoryWindowViewModel>(); }
        }

        public MenuWindowViewModel MenuWindowVm
        {
            get { return ServiceLocator.Current.GetInstance<MenuWindowViewModel>(); }
        }

        public static void Cleanup()
        {
        }
    }
}