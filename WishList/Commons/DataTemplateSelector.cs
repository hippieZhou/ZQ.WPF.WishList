using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WishList.Commons
{
    public class DataTemplateSelector
    {
        private static Dictionary<string, DataTemplate> DataTemplates = new Dictionary<string, DataTemplate>();

        private static DataTemplateSelector _current;
        public static DataTemplateSelector Current
        {
            get { return _current ?? (_current = new DataTemplateSelector()); }
            set { _current = value; }
        }

        private DataTemplateSelector() { }

        public DataTemplate GetDataTemplateByVM(ViewModelBase vm)
        {
            try
            {
                var name = vm.GetType().Name;
                if (!DataTemplates.ContainsKey(name))
                {
                    DataTemplates.Add(name, Application.Current.Resources[name] as DataTemplate);
                }
                return DataTemplates[name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
