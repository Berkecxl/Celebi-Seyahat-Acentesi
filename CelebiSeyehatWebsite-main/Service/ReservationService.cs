using Çelebi_Seyahat_Acentesi.Constant;
using Çelebi_Seyahat_Acentesi.Model;
using Çelebi_Seyahat_Acentesi.ModelBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Web;

namespace Çelebi_Seyahat_Acentesi.Service
{
    public class ReservationService
    {
        public static List<Reservation> getReservations()
        {
            string filePath = HttpContext.Current.Server.MapPath(Constants.ReservationsJson);
            string jsonFile = File.ReadAllText(filePath);

            List<Reservation> reservationList = JsonConvert.DeserializeObject<List<Reservation>>(jsonFile);
            return reservationList;
        }

        public static Reservation getReservationById(int id)
        {
            List<Reservation> reservationList = getReservations();
            
            return reservationList.FirstOrDefault(reservation => reservation.Id == id);
        }

        public static bool isReservationSuccess(int id, User user)
        {

            try
            {
                Reservation reservation = getReservationById(id);

                if (reservation != null)
                {
                    reservation.isPurchasable = false;
                    user.ownReservations.Add(reservation);
                    UserService.AddFeatureToUser(user);
                    UpdateReservationPurchaseStatus(reservation);

                    LogService.LogAction(reservation.Hotel, user.username, reservation.Price);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void UpdateReservationPurchaseStatus(Reservation updatedReservation)
        {
            List<Reservation> reservationList = getReservations();

            Reservation ticket = getReservationById(updatedReservation.Id);

            if (ticket != null)
            {
                int index = reservationList.FindIndex(t => t.Id == updatedReservation.Id);

                if (index != -1)
                {
                    reservationList[index].isPurchasable = updatedReservation.isPurchasable;

                    SaveReservationList(reservationList);
                }
            }
            else
            {
                //TODO hata mesajı
            }
        }

        private static void SaveReservationList(List<Reservation> reservationList)
        {
            File.WriteAllText(HttpContext.Current.Server.MapPath(Constants.ReservationsJson), JsonConvert.SerializeObject(reservationList));
        }
    }
}