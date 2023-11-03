using Autodesk.AutoCAD.DatabaseServices;
using AutoMapper;
using SyncPrime.Application.AutoMapper;
using SyncPrime.Application.Services.Interfaces;
using SyncPrime.Application.ViewModel;
using SyncPrime.Domain;
using SyncPrime.Domain.CadSevices;
using SyncPrime.Domain.Enums;
using SyncPrime.Domain.Models;
using SyncPrime.Infrastructure.CrossCutting.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SyncPrime.Application
{
    public class ServiceApp : IServiceApp
    {
        private readonly IUnitOfWork _uow;
        private readonly IDomainService _domainService;
        private readonly IAutoCadService _autoCadService;
        private readonly IMapper _mapper;

        public ServiceApp(IUnitOfWork unityOfWork, IDomainService domainService, IAutoCadService autoCadService, MapperBootStrap mapper)
        {
            _uow = unityOfWork;
            _domainService = domainService;
            _autoCadService = autoCadService;
            _mapper = mapper._mapper;
        }
        public void Save(LineViewModel line)
        {
            try
            {
                _uow.BeginTransaction();
                _domainService.Insert(_mapper.Map<LineModel>(line));
                _uow.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _uow.Rollback();
            }
        }
        public IEnumerable<LineViewModel> GetCurrentLines()
            => _mapper.Map<List<LineViewModel>>(_autoCadService.GetCurrentElement(CadEmun.TypedValue.LINE).Cast<Line>());
        public IEnumerable<MText> GetCurrentMText()
            => _autoCadService.GetCurrentElement(CadEmun.TypedValue.MTEXT).Cast<MText>();
        public IEnumerable<Polyline> GetCurrentLWPolyLine()
            => _autoCadService.GetCurrentElement(CadEmun.TypedValue.LWPOLYLINE).Cast<Polyline>();
        public IEnumerable<BlockReference> GetCurrentInsert()
            => _autoCadService.GetCurrentElement(CadEmun.TypedValue.INSERT).Cast<BlockReference>();
        public IEnumerable<LineViewModel> GetLines()
           => _mapper.Map<List<LineViewModel>>(_domainService.GetLines());




    }
}
