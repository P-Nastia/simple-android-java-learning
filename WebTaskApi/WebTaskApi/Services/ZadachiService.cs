using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using WebTaskApi.Data;
using WebTaskApi.Entities;
using WebTaskApi.Interfaces;
using WebTaskApi.Models.Zadacha;

namespace WebTaskApi.Services;

public class ZadachiService(AppDbContext context, IMapper mapper, IImageService imageService) : IZadachiService
{
    public async Task CreateZadachyAsync(ZadachaCreateModel model)
    {
        var zadachaEntity = mapper.Map<ZadachaEntity>(model);

        zadachaEntity.Image = await imageService.SaveImageAsync(model.Image);

        context.Zadachi.Add(zadachaEntity);
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<ZadachaItemModel>> GetAllAsync()
    {
        var zadachy = await context.Zadachi.ToListAsync();
        var zadachyModels = mapper.Map<IEnumerable<ZadachaItemModel>>(zadachy);
        return zadachyModels;
    }
}
