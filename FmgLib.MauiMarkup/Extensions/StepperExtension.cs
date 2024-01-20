﻿namespace FmgLib.MauiMarkup;



public static partial class StepperExtension
{
    public static T IncrementFmg<T>(this T self,
        double increment)
        where T : Stepper
    {
        self.SetValue(Stepper.IncrementProperty, increment);
        return self;
    }
    
    public static T IncrementFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Stepper
    {
        var context = new PropertyContext<double>(self, Stepper.IncrementProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IncrementFmg<T>(this SettersContext<T> self,
        double increment)
        where T : Stepper
    {
        self.XamlSetters.Add(new Setter { Property = Stepper.IncrementProperty, Value = increment });
        return self;
    }
    
    public static SettersContext<T> IncrementFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Stepper
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Stepper.IncrementProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateIncrementToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Stepper
    {
        double fromValue = self.Increment;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Increment = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateIncrementTo", transform, callback, length, easing);
    }
    
    public static T MaximumFmg<T>(this T self,
        double maximum)
        where T : Stepper
    {
        self.SetValue(Stepper.MaximumProperty, maximum);
        return self;
    }
    
    public static T MaximumFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Stepper
    {
        var context = new PropertyContext<double>(self, Stepper.MaximumProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MaximumFmg<T>(this SettersContext<T> self,
        double maximum)
        where T : Stepper
    {
        self.XamlSetters.Add(new Setter { Property = Stepper.MaximumProperty, Value = maximum });
        return self;
    }
    
    public static SettersContext<T> MaximumFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Stepper
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Stepper.MaximumProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateMaximumToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Stepper
    {
        double fromValue = self.Maximum;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Maximum = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateMaximumTo", transform, callback, length, easing);
    }
    
    public static T MinimumFmg<T>(this T self,
        double minimum)
        where T : Stepper
    {
        self.SetValue(Stepper.MinimumProperty, minimum);
        return self;
    }
    
    public static T MinimumFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Stepper
    {
        var context = new PropertyContext<double>(self, Stepper.MinimumProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MinimumFmg<T>(this SettersContext<T> self,
        double minimum)
        where T : Stepper
    {
        self.XamlSetters.Add(new Setter { Property = Stepper.MinimumProperty, Value = minimum });
        return self;
    }
    
    public static SettersContext<T> MinimumFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Stepper
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Stepper.MinimumProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateMinimumToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Stepper
    {
        double fromValue = self.Minimum;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Minimum = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateMinimumTo", transform, callback, length, easing);
    }
    
    public static T ValueFmg<T>(this T self,
        double value)
        where T : Stepper
    {
        self.SetValue(Stepper.ValueProperty, value);
        return self;
    }
    
    public static T ValueFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Stepper
    {
        var context = new PropertyContext<double>(self, Stepper.ValueProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ValueFmg<T>(this SettersContext<T> self,
        double value)
        where T : Stepper
    {
        self.XamlSetters.Add(new Setter { Property = Stepper.ValueProperty, Value = value });
        return self;
    }
    
    public static SettersContext<T> ValueFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Stepper
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Stepper.ValueProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateValueToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Stepper
    {
        double fromValue = self.Value;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Value = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateValueTo", transform, callback, length, easing);
    }
    
    public static T OnValueChangedFmg<T>(this T self, EventHandler<ValueChangedEventArgs> handler)
        where T : Stepper
    {
        self.ValueChanged += handler;
        return self;
    }
    
    public static T OnValueChangedFmg<T>(this T self, Action<T> action)
        where T : Stepper
    {
        self.ValueChanged += (o, arg) => action(self);
        return self;
    }
    
}
