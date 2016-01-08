using System;

namespace Algs4.InterviewQuestions.ParkingLot {
    public abstract class ParkingSpace {
        public string Id { get; private set; }
        public int DistanceToEntrance { get; private set; }
        public bool Occupied { get { return this.ParkedCar != null; } }
        public IVehicle ParkedCar { get; private set; }

        protected ParkingSpace(int distanceToEntrance, string id) {
            if (id == null) {
                throw new ArgumentNullException("id");
            }
            this.DistanceToEntrance = distanceToEntrance;
            this.Id = id;
        }

        protected string Park(IVehicle car) {
            if (this.Occupied) {
                throw new ApplicationException("Can't park a car in a full space");
            }
            this.ParkedCar = car;
            return this.Id;
        }

        public void VacateCar(){
            this.ParkedCar = null;
        }
    }
}
