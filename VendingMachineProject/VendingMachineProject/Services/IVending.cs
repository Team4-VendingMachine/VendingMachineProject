using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject.Services
{
    public interface IVending
    {
        void displayMenu();
        void selectItem();
        void insertMoney();
        void checkBalance();
        double returnChange();
    }
}
