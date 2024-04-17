﻿namespace FmgLib.MauiMarkup;



public static partial class ScaleTransformExtension
{
    public static T ScaleX<T>(this T self,
        double scaleX)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleXProperty, scaleX);
        return self;
    }
    
    public static T ScaleX<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ScaleX<T>(this SettersContext<T> self,
        double scaleX)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleXProperty, Value = scaleX });
        return self;
    }
    
    public static SettersContext<T> ScaleX<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleXProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ScaleY<T>(this T self,
        double scaleY)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleYProperty, scaleY);
        return self;
    }
    
    public static T ScaleY<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ScaleY<T>(this SettersContext<T> self,
        double scaleY)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleYProperty, Value = scaleY });
        return self;
    }
    
    public static SettersContext<T> ScaleY<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleYProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CenterX<T>(this T self,
        double centerX)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterXProperty, centerX);
        return self;
    }
    
    public static T CenterX<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CenterX<T>(this SettersContext<T> self,
        double centerX)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterXProperty, Value = centerX });
        return self;
    }
    
    public static SettersContext<T> CenterX<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterXProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CenterY<T>(this T self,
        double centerY)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterYProperty, centerY);
        return self;
    }
    
    public static T CenterY<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CenterY<T>(this SettersContext<T> self,
        double centerY)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterYProperty, Value = centerY });
        return self;
    }
    
    public static SettersContext<T> CenterY<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterYProperty);
        configure(context).Build();
        return self;
    }
    
}
