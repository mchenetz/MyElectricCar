﻿using System.Collections.ObjectModel;
using MyElectricCar.ViewModels.Interfaces;
using MyElectricCar.Shared.Models;

namespace MyElectricCar.ViewModels.Mocks
{
    public class MockHistoryViewModel : IHistoryViewModel
    {
        public ObservableCollection<ChargePointChargingSession> ChargingHistory
        {
            get
            {
                return new ObservableCollection<ChargePointChargingSession>
                {
                    new ChargePointChargingSession
                    {
                        CompanyId = 509,
                        SessionId = 36036197,
                        ChargingTime = 2349000,
                        CurrentCharging = "done",
                        Address1 = "1020 Enterprise Way",
                        VehicleId = 277903,
                        StateName = "California",
                        City = "Sunnyvale",
                        PowerKw = 0,
                        CompanyName = "Microsoft",
                        SessionTime = 2366000,
                        MilesAdded = 13.899909272727273,
                        Latitude = 37.40439224243164,
                        TotalAmount = 0.33,
                        Longitude = -122.03480529785156,
                        UpdatePeriod = 299800,
                        DeviceId = 107357,
                        OutletNumber = 2,
                        ApiFlag = false,
                        CurrencyIsoCode = "USD",
                        EndTime = 1450820809000,
                        StartOffset = -28800,
                        PortLevel = 2,
                        StartTime = 1450818443000,
                        PaymentType = "paid",
                        EnergyKwh = 3.775284
                    },

                    new ChargePointChargingSession
                    {
                        CompanyId = 509,
                        SessionId = 35977885,
                        ChargingTime = 11840000,
                        CurrentCharging = "done",
                        Address1 = "1020 Enterprise Way",
                        VehicleId = 277903,
                        StateName = "California",
                        City = "Sunnyvale",
                        PowerKw = 0,
                        CompanyName = "Microsoft",
                        SessionTime = 16132000,
                        MilesAdded = 54.40697468181818,
                        Latitude = 37.4044075012207,
                        TotalAmount = 2.24,
                        Longitude = -122.0348892211914,
                        UpdatePeriod = 300000,
                        DeviceId = 107203,
                        OutletNumber = 2,
                        ApiFlag = false,
                        CurrencyIsoCode = "USD",
                        EndTime = 1450739650000,
                        StartOffset = -28800,
                        PortLevel = 2,
                        StartTime = 1450723520000,
                        PaymentType = "paid",
                        EnergyKwh = 14.777203
                    }
                };
            }
        }
    }
}
