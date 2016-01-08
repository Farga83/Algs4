using System;
namespace Algs4.InterviewQuestions.ParkingLot {
    public class CompactSpace : ParkingSpace {
        public CompactSpace(int distanceToEntrance, string id) :
            base(distanceToEntrance, id) {
        }

        public string ParkCompactCar(CompactCar car) {
            if (car == null) {
                throw new ArgumentNullException("car");
            }
            return base.Park(car);
        }
    }
}
