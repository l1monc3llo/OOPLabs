using Itmo.ObjectOrientedProgramming.Lab2.PersonalComputers.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.SalesDepartment.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.SalesDepartment.Services;

public interface IPcOrderService
{
    PcOrderStatus PcSelling(Pc pc);
}