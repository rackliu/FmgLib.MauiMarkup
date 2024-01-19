﻿namespace FmgLib.MauiMarkup;

public static partial class DropGestureRecognizerExtension
{
    public static T AllowDropFmg<T>(this T self,
        bool allowDrop)
        where T : DropGestureRecognizer
    {
        self.SetValue(DropGestureRecognizer.AllowDropProperty, allowDrop);
        return self;
    }
    
    public static T AllowDropFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertyContext<bool>(self, DropGestureRecognizer.AllowDropProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AllowDropFmg<T>(this SettersContext<T> self,
        bool allowDrop)
        where T : DropGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = DropGestureRecognizer.AllowDropProperty, Value = allowDrop });
        return self;
    }
    
    public static SettersContext<T> AllowDropFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DropGestureRecognizer.AllowDropProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DragOverCommandFmg<T>(this T self,
        System.Windows.Input.ICommand dragOverCommand)
        where T : DropGestureRecognizer
    {
        self.SetValue(DropGestureRecognizer.DragOverCommandProperty, dragOverCommand);
        return self;
    }
    
    public static T DragOverCommandFmg<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, DropGestureRecognizer.DragOverCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DragOverCommandFmg<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand dragOverCommand)
        where T : DropGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = DropGestureRecognizer.DragOverCommandProperty, Value = dragOverCommand });
        return self;
    }
    
    public static SettersContext<T> DragOverCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, DropGestureRecognizer.DragOverCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DragOverCommandParameterFmg<T>(this T self,
        object dragOverCommandParameter)
        where T : DropGestureRecognizer
    {
        self.SetValue(DropGestureRecognizer.DragOverCommandParameterProperty, dragOverCommandParameter);
        return self;
    }
    
    public static T DragOverCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertyContext<object>(self, DropGestureRecognizer.DragOverCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DragOverCommandParameterFmg<T>(this SettersContext<T> self,
        object dragOverCommandParameter)
        where T : DropGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = DropGestureRecognizer.DragOverCommandParameterProperty, Value = dragOverCommandParameter });
        return self;
    }
    
    public static SettersContext<T> DragOverCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, DropGestureRecognizer.DragOverCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DragLeaveCommandFmg<T>(this T self,
        System.Windows.Input.ICommand dragLeaveCommand)
        where T : DropGestureRecognizer
    {
        self.SetValue(DropGestureRecognizer.DragLeaveCommandProperty, dragLeaveCommand);
        return self;
    }
    
    public static T DragLeaveCommandFmg<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, DropGestureRecognizer.DragLeaveCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DragLeaveCommandFmg<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand dragLeaveCommand)
        where T : DropGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = DropGestureRecognizer.DragLeaveCommandProperty, Value = dragLeaveCommand });
        return self;
    }
    
    public static SettersContext<T> DragLeaveCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, DropGestureRecognizer.DragLeaveCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DragLeaveCommandParameterFmg<T>(this T self,
        object dragLeaveCommandParameter)
        where T : DropGestureRecognizer
    {
        self.SetValue(DropGestureRecognizer.DragLeaveCommandParameterProperty, dragLeaveCommandParameter);
        return self;
    }
    
    public static T DragLeaveCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertyContext<object>(self, DropGestureRecognizer.DragLeaveCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DragLeaveCommandParameterFmg<T>(this SettersContext<T> self,
        object dragLeaveCommandParameter)
        where T : DropGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = DropGestureRecognizer.DragLeaveCommandParameterProperty, Value = dragLeaveCommandParameter });
        return self;
    }
    
    public static SettersContext<T> DragLeaveCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, DropGestureRecognizer.DragLeaveCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DropCommandFmg<T>(this T self,
        System.Windows.Input.ICommand dropCommand)
        where T : DropGestureRecognizer
    {
        self.SetValue(DropGestureRecognizer.DropCommandProperty, dropCommand);
        return self;
    }
    
    public static T DropCommandFmg<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, DropGestureRecognizer.DropCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DropCommandFmg<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand dropCommand)
        where T : DropGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = DropGestureRecognizer.DropCommandProperty, Value = dropCommand });
        return self;
    }
    
    public static SettersContext<T> DropCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, DropGestureRecognizer.DropCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DropCommandParameterFmg<T>(this T self,
        object dropCommandParameter)
        where T : DropGestureRecognizer
    {
        self.SetValue(DropGestureRecognizer.DropCommandParameterProperty, dropCommandParameter);
        return self;
    }
    
    public static T DropCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertyContext<object>(self, DropGestureRecognizer.DropCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DropCommandParameterFmg<T>(this SettersContext<T> self,
        object dropCommandParameter)
        where T : DropGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = DropGestureRecognizer.DropCommandParameterProperty, Value = dropCommandParameter });
        return self;
    }
    
    public static SettersContext<T> DropCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : DropGestureRecognizer
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, DropGestureRecognizer.DropCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnDragLeaveFmg<T>(this T self, EventHandler<DragEventArgs> handler)
        where T : DropGestureRecognizer
    {
        self.DragLeave += handler;
        return self;
    }
    
    public static T OnDragLeaveFmg<T>(this T self, Action<T> action)
        where T : DropGestureRecognizer
    {
        self.DragLeave += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDragOverFmg<T>(this T self, EventHandler<DragEventArgs> handler)
        where T : DropGestureRecognizer
    {
        self.DragOver += handler;
        return self;
    }
    
    public static T OnDragOverFmg<T>(this T self, Action<T> action)
        where T : DropGestureRecognizer
    {
        self.DragOver += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDropFmg<T>(this T self, EventHandler<DropEventArgs> handler)
        where T : DropGestureRecognizer
    {
        self.Drop += handler;
        return self;
    }
    
    public static T OnDropFmg<T>(this T self, Action<T> action)
        where T : DropGestureRecognizer
    {
        self.Drop += (o, arg) => action(self);
        return self;
    }
    
}