using System;

namespace Algs4.InterviewQuestions.ParkingLot {
    public class CompactCar : IVehicle {
        private bool handicapDriver;
        private string licensePlate;
        private string make;
        private string model;

        public CompactCar(
            bool handicapDriver,
            string licensePlate,
            string make,
            string model) {
            if (licensePlate == null) {
                throw new ArgumentNullException("licensePlate");
            }
            this.handicapDriver = handicapDriver;
            this.licensePlate = licensePlate;
            this.make = make;
            this.model = model;
        }

        public bool HandicapDriver() {
            return this.handicapDriver;
        }

        public string LicensePlate() {
            return this.licensePlate;
        }

        public string Make() {
            return this.Make();
        }

        public string Model() {
            return this.Model();
        }
    }
}
