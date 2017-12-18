using Android.App;
using Android.Widget;
using Android.OS;

namespace Xamarin_TipCalculator
{
    [Activity(Label = "Xamarin_TipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //private EditText inputBill;
        //private Button calculateButton;

        //int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            EditText inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            Button calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            calculateButton.Click += OnCalculateClick;


        }

        void OnCalculateClick(object sender, ItemEventArgs e)
        {
            string text = inputBill.Text;
            var bill = double.Parse(text);

            var tip = bill * 0.15;
            var total = bill + tip;

            outputTip.Text = tip.ToString();
            outputTotal.Text = total.ToString();
        }
    }
}

