using System;
using System.Collections.Generic;
using System.Text;

namespace Marketplace.Domain
{
    public class ClassifiedAd
    {
        public Guid Id { get; set; }
        public ClassifiedAd(Guid id, UserId ownerId)
        {
            if (id == default)
                throw new ArgumentException(
                "Identity must be specified", nameof(id));
            if (ownerId == default)
                throw new ArgumentException(
                "Owner id must be specified", nameof(ownerId));
            Id = id;
            _ownerId = ownerId;
        }
        private UserId _ownerId { get; set; }
        private string _title { get; set; }
        private string _text { get; set; }
        private decimal _price { get; set; }
        public void SetTitle(string title) => _title = title;
        public void UpdatePrice(decimal price) => _price = price;
        public void UpdateText(string text) => _text = text;


    }
}
