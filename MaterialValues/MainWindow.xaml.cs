using MaterialValues.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaterialValues
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Context db;

        public MainWindow()
        {
            InitializeComponent();



            db = new Context();
            db.values.Load();
            db.suppliers.Load();

            //создание контекста
            var valInfo = db.values.ToList();
            var supInfo = db.suppliers.ToList();
            //запрос на соеденение таблиц
            var info = valInfo.Join(supInfo, p => p.SipplierID, c => c.ID, 
                (c, p) => new {Name = c.Name, NumberOfDocument = p.NumberOfDocument, 
                DateOfDocument = p.DateOfDocument, SerialNumber = c.SerialNumber, c.Count, p.NameOFOrganization, c.Info})
                .ToList();
            valuesList.ItemsSource = info;

            //вывод в комобокс
            var supList = db.suppliers.Select(p => p.NameOFOrganization).ToList();
            Organisation.ItemsSource = supList;
            
        }

        public void loadData(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Context context = new Context())
                {
                    Supplier supplier = new Supplier {NumberOfDocument = int.Parse(NumberOfDocument.Text), DateOfDocument = DateOfDocument.Text.ToString(), NameOFOrganization = Organisation.Text};


                    Value value = new Value
                    {
                        Name = NameOfValue.Text,
                        Count = int.Parse(CountOfValue.Text),
                        PriceForOneCount = int.Parse(CoastOfValue.Text),
                        Size = float.Parse(Size.Text),
                        Height = float.Parse(Height.Text),
                        Length = float.Parse(Length.Text),
                        Width = float.Parse(Width.Text),
                        SerialNumber = int.Parse(SerialNumber.Text),
                        Info = Note.Text,
                        SipplierID = supplier.ID
                        };
                    context.suppliers.Add(supplier);
                    context.values.Add(value);
                }

                MessageBox.Show("МЦ сохранена");

            }
            catch(Exception error)
            {
                MessageBox.Show("Произошла ошибка" + error);
            }
        }

        private void MakeARecordOfAccounting_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
