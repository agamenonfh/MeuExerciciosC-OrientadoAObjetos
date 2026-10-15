using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    // Por convenção Interfaces possuem o 'I' maiúsculo no inicio do nome da classe interface
    interface ITaxService
    {
        double Tax(double amount);
    }
}
