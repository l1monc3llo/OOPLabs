using System;
using Itmo.ObjectOrientedProgramming.Lab2.PersonalComputers.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.SalesDepartment.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.SalesDepartment.Services;

public class PcOrderService : IPcOrderService
{
    public PcOrderStatus PcSelling(Pc pc)
    {
        if (pc is null)
        {
            throw new ArgumentNullException(nameof(pc));
        }

        if (pc.CalculateSystemLoad() > pc.Psu?.PeakLoadInW)
        {
            return PcOrderStatus.WarrantyDisclaimerWeakClaimedMaxLoadPsu;
        }

        if (pc.Cpu?.Tdp > pc.CoolingSystem?.MaxTdp)
        {
            return PcOrderStatus.WarrantyDisclaimerWeakClaimedMaxTdpCoolingSystem;
        }

        return PcOrderStatus.Successful;
    }
}