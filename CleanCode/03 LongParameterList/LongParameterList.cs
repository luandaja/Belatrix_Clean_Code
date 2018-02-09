
using System;
using System.Collections.Generic;

namespace CleanCode.LongParameterList
{
    public class ReservationRangeDTO
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

    }
    public class Location
    {
        public int Id { get; set; }
        public LocationType Type { get; set; }

    }
    public class ReservationDTO : ReservationRangeDTO
    {
        public Location Location { get; set; }
        public int? CustomerId { get; set; }
    }
    public class ReservationDetailDTO : ReservationDTO
    {
        public User User { get; set; }
        //public Location Location { get; set; }
        //public int? CustomerId { get; set; }
    }
    public class LongParameterList
    {
        public IEnumerable<Reservation> GetReservations(ReservationDetailDTO reservation)
        {
            if (reservation.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservation.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(ReservationDetailDTO reservation)
        {
            if (reservation.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservation.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(ReservationRangeDTO reservation, ReservationDefinition sd)
        {
            if (reservation.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservation.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(ReservationDTO reservation)
        {
            if (reservation.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (reservation.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }

    internal class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class User
    {
        public object Id { get; set; }
    }

    public class Reservation
    {
    }
}
