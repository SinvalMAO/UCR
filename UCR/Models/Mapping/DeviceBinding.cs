﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCR.Models.Devices;

namespace UCR.Models.Mapping
{
    public enum DeviceBindingType
    {
        Input,
        Output
    }

    public class DeviceBinding
    {
        // Persistence
        // Keyboard, mouse, joystick
        public DeviceType? DeviceType { get; set; }
        // Index in its device list
        public int DeviceNumber { get; set; }
        // Subscription key
        public int KeyType { get; set; }
        public int KeyValue { get; set; }

        // Runtime
        public String PluginName { get; set; }
        public delegate void ValueChanged(long value);
        public ValueChanged Callback { get; set; }

        public DeviceBinding(ValueChanged callback)
        {
            Callback = callback;
        }

        public DeviceBinding(DeviceBinding deviceBinding)
        {
            DeviceType = deviceBinding.DeviceType;
            DeviceNumber = deviceBinding.DeviceNumber;
            KeyType = deviceBinding.KeyType;
            KeyValue = deviceBinding.KeyValue;
            PluginName = deviceBinding.PluginName;
            Callback = deviceBinding.Callback;
        }
    }
}