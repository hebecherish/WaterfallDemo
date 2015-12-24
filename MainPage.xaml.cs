﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace WaterfallDemo
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Random r = new Random(DateTime.Now.Millisecond);
         
           // string url = "ms-appx:///Assets/Images/1.jpg";
            //BitmapImage bmp = new BitmapImage(new Uri(url));
            //bmp.PixelWidth
            //bmp.PixelHeight

            //http://blog.csdn.net/oTerminator12/article/details/38668317
            //http://stackoverflow.com/questions/15406315/bitmapimage-returns-0-for-pixelwidth-and-pixelheight
            ic.ItemsSource = Enumerable.Range(0, 30).Select(i => new MyItem { Text = i.ToString(),
                Height = r.Next(100, 300),
                Url = string.Format("ms-appx:///Assets/Images/{0}.jpg", i)
            });
        }
    }
}
