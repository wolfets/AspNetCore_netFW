using System;
using System.Net;
using System.Windows;
using System.ComponentModel;

namespace AspNetCore_netFW.Model
{
  public class ModelObject : INotifyPropertyChanged
  {
    private int _shoesize;

    public int Shoesize
    {
      get { return _shoesize; }
      set
      {
        _shoesize = value;
        OnPropertyChanged("Shoesize");
      }
    }

    private double _height;

    public double Height
    {
      get { return _height; }
      set
      {
        _height = value;
        OnPropertyChanged("Height");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }
  }
}
