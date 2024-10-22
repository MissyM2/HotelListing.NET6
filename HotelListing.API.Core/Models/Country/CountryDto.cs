﻿using HotelListing.API.Core.Models.Hotel;

namespace HotelListing.API.Core.Models.Country
{
    public class CountryDto : BaseCountryDto, IBaseDto
    {
        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }
        int IBaseDto.id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}