using Chatbot.Common;
using System;

namespace Chatbot.Api
{
    public static class SessionManager
    {
        public static SessionDto Read(string user)
        {
            try
            {
                return Cache.Get<SessionDto>(user);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Create(SessionDto session)
        {
            try
            {
                return Cache.Add(session.User, session);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete(string user)
        {
            try
            {
                return Cache.Delete(user);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void KeepSessíon(string user, dynamic context, SessionDto session)
        {
            if (session != null)
            {
                Cache.Update(user, new SessionDto { User = user, Context = context, Token = session.Token });
            }
            else
            {
                Cache.Add(user, new SessionDto { User = user, Context = context });
            }
        }
    }
}
