using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.DTOs.Publisher;

namespace BusinessLayer.Services.Interfaces;

public interface IPublisherService
{
    Task<IEnumerable<ResponsePublisherDto>> GetAllPublishersAsync();
    Task<ResponsePublisherDto> GetPublisherByIdAsync(int id);
    Task<ResponsePublisherDto> AddPublisherAsync(AddPublisherDto addPublisherDto);
    Task<ResponsePublisherDto> UpdatePublisherAsync(int id, UpdatePublisherDto updatePublisherDto);
    Task DeletePublisherAsync(int id);
}
