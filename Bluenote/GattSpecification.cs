﻿using System.Collections.Generic;

namespace Bluenote
{
    internal static class GattSpecification
    {
        private static readonly Dictionary<ushort, string> SpecificationName = new Dictionary<ushort, string>
        {
            {0x1811, "Alert Notification Service"},
            {0x1815, "Automation IO"},
            {0x180F, "Battery Service"},
            {0x1810, "Blood Pressure"},
            {0x181B, "Body Composition"},
            {0x181E, "Bond Management"},
            {0x181F, "Continuous Glucose Monitoring"},
            {0x1805, "Current Time Service"},
            {0x1818, "Cycling Power"},
            {0x1816, "Cycling Speed and Cadence"},
            {0x180A, "Device Information"},
            {0x181A, "Environmental Sensing"},
            {0x1800, "Generic Access"},
            {0x1801, "Generic Attribute"},
            {0x1808, "Glucose"},
            {0x1809, "Health Thermometer"},
            {0x180D, "Heart Rate"},
            {0x1823, "HTTP Proxy"},
            {0x1812, "Human Interface Device"},
            {0x1802, "Immediate Alert"},
            {0x1821, "Indoor Positioning"},
            {0x1820, "Internet Protocol Support"},
            {0x1803, "Link Loss"},
            {0x1819, "Location and Navigation"},
            {0x1807, "Next DST Change Service"},
            {0x1825, "Object Transfer"},
            {0x180E, "Phone Alert Status Service"},
            {0x1822, "Pulse Oximeter"},
            {0x1806, "Reference Time Update Service"},
            {0x1814, "Running Speed and Cadence"},
            {0x1813, "Scan Parameters"},
            {0x1824, "Transport Discovery"},
            {0x1804, "Tx Power"},
            {0x181C, "User Data"},
            {0x181D, "Weight Scale"}
        };

        public static string GetSpecificationName(ushort uuid)
        {
            string name;
            if (SpecificationName.TryGetValue(uuid, out name))
                return name;
            return null;
        }
    }
}
