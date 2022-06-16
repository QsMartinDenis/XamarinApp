using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrsApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomButton : ContentView
    {
        public CustomButton()
        {
            InitializeComponent();
        }
       
        #region BindableProperty

        public static BindableProperty ClickedProperty =
            BindableProperty.Create(nameof(ClickedButton), typeof(Action<object,EventArgs>), typeof(CustomButton), null);

        public static BindableProperty IsEnabledButtonProperty =
            BindableProperty.Create(nameof(IsEnabledButton), typeof(bool), typeof(CustomButton), false);

        public static BindableProperty BackGroundColorProperty =
            BindableProperty.Create(nameof(BackGroundColorButton), typeof(Color), typeof(CustomButton), default(Color));

        public static BindableProperty CornerRadiusProperty =
            BindableProperty.Create(nameof(CornerRadiusButton), typeof(int), typeof(CustomButton), 0);

        public static BindableProperty TextProperty =
            BindableProperty.Create(nameof(TextButton), typeof(string), typeof(CustomButton), string.Empty);

        public static BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColorButton), typeof(Color), typeof(CustomButton), Color.Black);

        public static BindableProperty BorderColorProperty =
            BindableProperty.Create(nameof(BorderColorButton), typeof(Color), typeof(CustomButton), Color.Transparent);

        public static BindableProperty BorderWidthProperty =
            BindableProperty.Create(nameof(BorderWidthButton), typeof(int), typeof(CustomButton), 0);

        #endregion

        #region Get && Set

        public Action<object, EventArgs> ClickedButton
        {
            set => SetValue(ClickedProperty, value);
            get => (Action<object, EventArgs>)GetValue(ClickedProperty);
        }

        public bool IsEnabledButton
        {
            get => (bool)GetValue(IsEnabledButtonProperty);
            set => SetValue(IsEnabledButtonProperty, value);
        }
        public Color TextColorButton
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }
        public string TextButton
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        public int CornerRadiusButton
        {
            get => (int)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public Color BackGroundColorButton
        {
            get => (Color)GetValue(BackGroundColorProperty);
            set => SetValue(BackGroundColorProperty, value);
        }

        public Color BorderColorButton
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        public int BorderWidthButton
        {
            get => (int)GetValue(BorderWidthProperty);
            set => SetValue(BorderWidthProperty,value);
        }

        #endregion

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == nameof(IsEnabledButton))
            {
                button.IsEnabled = IsEnabledButton;
            }
            if (propertyName == nameof(BackGroundColorButton))
            {
                button.BackgroundColor = BackGroundColorButton;
            }
            if (propertyName == nameof(CornerRadiusButton))
            {
                button.CornerRadius = CornerRadiusButton;
            }
            if (propertyName == nameof(TextButton))
            {
                button.Text = TextButton;
            }
            if (propertyName == nameof(TextColorButton))
            {
                button.TextColor = TextColorButton;
            }
            if (propertyName == nameof(BorderColorButton))
            {
                button.BorderColor = BorderColorButton;
            }
            if (propertyName == nameof(BorderWidthButton))
            {
                button.BorderWidth = BorderWidthButton;
            }
            if (propertyName == nameof(ClickedButton))
            {
                button.Clicked += new EventHandler(ClickedButton);
            }
        }
    }
}