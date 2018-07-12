﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Java.Lang;
using Java.Lang.Reflect;
using Android.Util;
using Android.OS;
using Android.Graphics;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Envelope_Internal.Droid;
using Android.Widget;

namespace Envelope_Internal.Droid
{
    public class CustomLayoutInflaterFactory : Java.Lang.Object, LayoutInflater.IFactory
    {
        static Class ActionMenuItemViewClass = null;
        static Constructor ActionMenuItemViewConstructor = null;

        static Typeface typeface = null;
        public static Typeface Typeface
        {
            get
            {
                if (typeface == null)
                    typeface = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "Fonts/fontawesome.ttf");

                return typeface;
            }
        }

        public View OnCreateView(string name, Context context, IAttributeSet attrs)
        {
            if (name.Equals("com.android.internal.view.menu.ActionMenuItemView", StringComparison.InvariantCultureIgnoreCase))
            {
                View view = null;

                try
                {
                    if (ActionMenuItemViewClass == null)
                        ActionMenuItemViewClass = ClassLoader.SystemClassLoader.LoadClass(name);
                }
                catch (ClassNotFoundException)
                {
                    return null;
                }

                if (ActionMenuItemViewClass == null)
                    return null;

                if (ActionMenuItemViewConstructor == null)
                {
                    try
                    {
                        ActionMenuItemViewConstructor = ActionMenuItemViewClass.GetConstructor(new Class[] {
                            Class.FromType(typeof(Context)),
                            Class.FromType(typeof(IAttributeSet))
                        });
                    }
                    catch (SecurityException)
                    {
                        return null;
                    }
                    catch (NoSuchMethodException)
                    {
                        return null;
                    }
                }
                if (ActionMenuItemViewConstructor == null)
                    return null;

                try
                {
                    Java.Lang.Object[] args = new Java.Lang.Object[] { context, (Java.Lang.Object)attrs };
                    view = (View)(ActionMenuItemViewConstructor.NewInstance(args));
                }
                catch (IllegalArgumentException)
                {
                    return null;
                }
                catch (InstantiationException)
                {
                    return null;
                }
                catch (IllegalAccessException)
                {
                    return null;
                }
                catch (InvocationTargetException)
                {
                    return null;
                }
                if (null == view)
                    return null;

                View v = view;

                new Handler().Post(() => {

                    try
                    {
                        if (v is LinearLayout)
                        {
                            var ll = (LinearLayout)v;
                            for (int i = 0; i < ll.ChildCount; i++)
                            {
                                var button = ll.GetChildAt(i) as Button;

                                if (button != null)
                                {
                                    var title = button.Text;

                                    if (!string.IsNullOrEmpty(title) && title.Length == 1)
                                    {
                                        button.SetTypeface(Typeface, TypefaceStyle.Normal);
                                    }
                                }
                            }
                        }
                        else if (v is TextView)
                        {
                            var tv = (TextView)v;
                            string title = tv.Text;

                            if (!string.IsNullOrEmpty(title) && title.Length == 1)
                            {
                                tv.SetTypeface(Typeface, TypefaceStyle.Normal);
                            }
                        }
                    }
                    catch (ClassCastException)
                    {
                    }
                });

                return view;
            }

            return null;
        }
    }
}