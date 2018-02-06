using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.SessionCreateRQ;


namespace Services.Air.Session
{
    public class CrearSesion
    {
        //public static string CrearSesion()
        //{
        //    try
        //    {
        //        MessageHeader msgHeader = BuildMessageHead();
        //        Security security = BuildSecurity();
        //        SessionCreateRQ.SessionCreateRQ session = new SessionCreateRQ.SessionCreateRQ();
        //        SessionCreateRQ.SessionCreateRQPOS pos = new SessionCreateRQPOS();
        //        SessionCreateRQ.SessionCreateRQPOSSource source = new SessionCreateRQPOSSource();
        //        source.PseudoCityCode = "7MSH";
        //        pos.Source = source;
        //        session.POS = pos;
        //        SessionCreateRQService crearServicio = new SessionCreateRQService();
        //        crearServicio.MessageHeaderValue = msgHeader;
        //        crearServicio.SecurityValue = security;
        //        SessionCreateRS result = crearServicio.SessionCreateRQ(session);
        //        if (result.Errors != null)
        //        {
        //            return result.Errors.Error.ErrorMessage;
        //        }
        //        else
        //        {
        //            security = crearServicio.SecurityValue;
        //            return security.BinarySecurityToken;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}

        public static MessageHeader BuildMessageHead()
        {
            MessageHeader msgHeader = new MessageHeader();

            DateTime Fecha_ = DateTime.UtcNow;
            string Tiempo_ = Fecha_.ToString("s") + "Z";

            From from = new From();
            PartyId partyFromId = new PartyId();
            PartyId[] fromPartyArray = new PartyId[1];
            Service servicio = new Service();
            MessageData msgData = new MessageData();

            // Identifies the party that originated the message
            partyFromId.Value = "99999";
            fromPartyArray[0] = partyFromId;
            from.PartyId = fromPartyArray;

            To to = new To();
            PartyId partyToId = new PartyId();
            PartyId[] partyToArray = new PartyId[1];
            partyToId.Value = "123123";
            partyToArray[0] = partyToId;
            to.PartyId = partyToArray;

            servicio.Value = "SessionCreate";

            msgData.MessageId = "mid:20001209-133003-2333@clientofsabre.com1";
            msgData.Timestamp = Tiempo_;

            msgHeader.ConversationId = "Reservas - Corporativo.";
            msgHeader.From = from;
            msgHeader.To = to;
            msgHeader.Service = servicio;

            msgHeader.CPAId = "9EOH";
            msgHeader.Action = "SessionCreateRQ";
            msgHeader.MessageData = msgData;
            return msgHeader;

        }

        public static Security BuildSecurity()
        {
            Security security = new Security();
            SecurityUsernameToken usertoken = new SecurityUsernameToken();
            usertoken.Domain = "DEFAULT";
            usertoken.Password = "WS091015";
            usertoken.Username = "7971";
            usertoken.Organization = "9EOH";
            security.UsernameToken = usertoken;
            return security;
        }
    }
}
