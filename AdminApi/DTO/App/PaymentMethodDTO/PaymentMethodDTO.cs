using System;

namespace AdminApi.DTO.App.PaymentMethodDTO
{
    public class PaymentMethodDTO
    {
        public string PaymentMethodName { get; set; }
        public int CreatedBy { get; set; }
       
    }

    public class UpdatePaymentMenthodDTO
    {
        public int PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
