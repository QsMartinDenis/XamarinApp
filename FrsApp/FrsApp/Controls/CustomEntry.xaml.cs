using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrsApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomEntry : ContentView
    {

        public static BindableProperty BackGroundColorProperty =
            BindableProperty.Create(nameof(BackGroundColorEntry), typeof(Color), typeof(CustomEntry), Color.Black);

        public static BindableProperty PlaceholderProperty =
            BindableProperty.Create(nameof(PlaceholderEntry), typeof(string), typeof(CustomEntry), string.Empty, BindingMode.TwoWay);

        public static BindableProperty HorizontalTextAlignmentProperty =
            BindableProperty.Create(nameof(HorizontalTextAlignmentEntry), typeof(TextAlignment), typeof(CustomEntry), TextAlignment.Start);

        public static BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColorEntry), typeof(Color), typeof(CustomEntry), Color.Black);

        public static BindableProperty CornerRadiusProperty =
             BindableProperty.Create(nameof(CornerRadiusEntry), typeof(int), typeof(CustomButton), 0);

        public static BindableProperty TextLabelProperty =
            BindableProperty.Create(nameof(TextLabelEntry), typeof(string), typeof(CustomEntry), defaultValue: null);

        public static BindableProperty IsVisibleLabelProperty =
            BindableProperty.Create(nameof(IsVisibleLabelEntry), typeof(bool), typeof(CustomEntry), defaultValue: false);

        public static BindableProperty TextEntryProperty =
            BindableProperty.Create(nameof(TextEntry), typeof(string), typeof(CustomEntry), defaultValue: string.Empty);


        public Action<CustomEntry, TextChangedEventArgs> Object { get; set; }
        public Color BackGroundColorEntry
        {
            get => (Color)GetValue(BackGroundColorProperty);
            set => SetValue(BackGroundColorProperty, value);
        }

        public string PlaceholderEntry
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }
        public TextAlignment HorizontalTextAlignmentEntry
        {
            get => (TextAlignment)GetValue(HorizontalTextAlignmentProperty);
            set => SetValue(HorizontalTextAlignmentProperty, value);
        }
        public Color TextColorEntry
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        public int CornerRadiusEntry
        {
            get => (int)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public string TextLabelEntry
        {
            get => (string)GetValue(TextLabelProperty);
            set => SetValue(TextLabelProperty, value);
        }

        public bool IsVisibleLabelEntry
        {
            get => (bool)GetValue(IsVisibleLabelProperty);
            set => SetValue(IsVisibleLabelProperty, value);
        }

        public string TextEntry
        {
            get => (string)GetValue(TextEntryProperty);
            set => SetValue(TextEntryProperty, value);
        }

        public CustomEntry()
        {
            InitializeComponent();

            entry.TextChanged += Entry_TextChanged;
            entry.TextChanged += (S, e) =>
            {
                Object?.Invoke(this, e);
            };
        }
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextEntry = e.NewTextValue;
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == nameof(BackGroundColorEntry))
            {
                entry.BackgroundColor = BackGroundColorEntry;
            }
            if (propertyName == nameof(PlaceholderEntry))
            {
                entry.Placeholder = PlaceholderEntry;
            }
            if (propertyName == nameof(HorizontalTextAlignmentEntry))
            {
                entry.HorizontalTextAlignment = HorizontalTextAlignmentEntry;
            }
            if (propertyName == nameof(TextColorEntry))
            {
                entry.TextColor = TextColorEntry;
            }
            if (propertyName == nameof(CornerRadiusEntry))
            {
                frame.CornerRadius = CornerRadiusEntry;
            }
            if (propertyName == nameof(TextLabelEntry))
            {
                label.Text = TextLabelEntry;
            }
            if (propertyName == nameof(IsVisibleLabelEntry))
            {
                label.IsVisible = IsVisibleLabelEntry;
            }
            if (propertyName == nameof(TextEntry))
            {
                entry.Text = TextEntry;
            }
        }
    }
}