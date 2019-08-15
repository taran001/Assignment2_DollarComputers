using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarComputers
{
    /// <summary>
    /// Application Name : DollarComputers
    /// Author : Taranpreet Singh
    /// ID : 301044958
    /// App Creation Date : 14 / 05 / 2019
    /// </summary>
    public class Product
    {
        int _productID;
        double _cost;
        string _condition, _platform, _OS, _manufac, _model, _memory, _lcd, _hdd, _cpuBrand, _cpuNumber,
               _gpuType, _cpuType, _cpuSpeed, _webcam;

        public Product()
        {

        }
        public int ProductID
        {
            get
            {
                return _productID;
            }

            set
            {
                _productID = value;
            }
        }

        public double Cost
        {
            get
            {
                return _cost;
            }

            set
            {
                _cost = value;
            }
        }

        public string Condition
        {
            get
            {
                return _condition;
            }

            set
            {
                _condition = value;
            }
        }

        public string Platform
        {
            get
            {
                return _platform;
            }

            set
            {
                _platform = value;
            }
        }

        public string OS
        {
            get
            {
                return _OS;
            }

            set
            {
                _OS = value;
            }
        }

        public string Manufac
        {
            get
            {
                return _manufac;
            }

            set
            {
                _manufac = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        public string Memory
        {
            get
            {
                return _memory;
            }

            set
            {
                _memory = value;
            }
        }

        public string Lcd
        {
            get
            {
                return _lcd;
            }

            set
            {
                _lcd = value;
            }
        }

        public string Hdd
        {
            get
            {
                return _hdd;
            }

            set
            {
                _hdd = value;
            }
        }

        public string CpuBrand
        {
            get
            {
                return _cpuBrand;
            }

            set
            {
                _cpuBrand = value;
            }
        }

        public string CpuNumber
        {
            get
            {
                return _cpuNumber;
            }

            set
            {
                _cpuNumber = value;
            }
        }

        public string GpuType
        {
            get
            {
                return _gpuType;
            }

            set
            {
                _gpuType = value;
            }
        }

        public string CpuType
        {
            get
            {
                return _cpuType;
            }

            set
            {
                _cpuType = value;
            }
        }

        public string CpuSpeed
        {
            get
            {
                return _cpuSpeed;
            }

            set
            {
                _cpuSpeed = value;
            }
        }

        public string Webcam
        {
            get
            {
                return _webcam;
            }

            set
            {
                _webcam = value;
            }
        }
    }
}
