using System;

namespace Deveel.Link.Models {
	public static class ResultCodes {
		public const int UnknownError = 0;
		public const int TemporaryRoutingError = 1;
		public const int PermanentRoutingError = 2;
		public const int MaxThrottlingExceeded = 3;
		public const int Timeout = 4;
		public const int OperatorUnknownError = 5;
		public const int OperatorError = 6;

		public const int ConfigurationError = 104;
		public const int InternalError = 105;

		public const int SentToOperator = 1000;
		public const int BilledAndDelivered = 1001;
		public const int Expired = 1002;
		public const int Deleted = 1003;
		public const int MobileFull = 1004;
		public const int Queued = 1005;
		public const int NotDelivered = 1006;
		public const int DeliveredBilledDelayed = 1007;
		public const int BilledOk = 1008;
		public const int BilledOkNotDelivered = 1009;
		public const int ExpiredNotOperatorDlr = 1010;
		public const int BilledOkSentToOperator = 1011;
		public const int Delayed = 1012;
		public const int SentToOperatorBillingDelayed = 1013;

		public const int InvalidSource = 2000;
		public const int SourceShortNumberNotSupported = 2001;
		public const int SourceAlphaNumericNotSupported = 2002;
		public const int SourceMsisdnNotSupported = 2003;

		public const int DestinationShortNumberNotSupported = 2100;
		public const int DestinationAlphaNumericNotSupported = 2101;
		public const int DestinationMsisdnNotSupported = 2102;
		public const int OperationBlocked = 2103;
		public const int UnknownSubscriber = 2104;
		public const int DestinationBlocked = 2105;
		public const int NumberError = 2106;
		public const int DestinationTemporarilyBlocked = 2107;

		public const int ChargingError = 2200;
		public const int SubscriberLowBalance = 2201;
		public const int SubscriberOvercharged = 2202;
		public const int SubscriberTooYoung = 2203;
		public const int PrepaidSubscriberNotAllowed = 2204;
		public const int ServiceRejectedBySubscriber = 2205;
		public const int SubscriberNotRegistered = 2206;
		public const int SubscriberMaxBalance = 2207;

		public const int GsmEncodingNotSupported = 3000;
		public const int Uc2EncodingNotSupported = 3001;
		public const int BinaryEncodingNotSupported = 3002;

		public const int DeliveryReportNotSupported = 4000;
		public const int InvalidMessageContent = 4001;
		public const int InvalidTariff = 4002;
		public const int InvalidUserData = 4003;
		public const int InvalidUserDataHeader = 4004;
		public const int InvalidDataCoding = 4005;
		public const int InvalidVat = 4006;
		public const int ContentNotSupportedByDestination = 4007;
	}
}
