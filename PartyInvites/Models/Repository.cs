using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models {
    public class Repository {
        private static List<GuestRespnse> responses = new List<GuestRespnse>();
        public static IEnumerable<GuestRespnse> Responses {
            get {
                return responses;
            }
        }
        public static void AddResponse(GuestRespnse response) {
            responses.Add(response);
        }

        }
    }

