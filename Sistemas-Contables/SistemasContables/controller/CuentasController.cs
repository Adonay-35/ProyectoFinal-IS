using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class CuentasController
    {
        private CuentasDAO cuentasDAO;

        private List<Cuenta> lista;
        private bool estado = false;

        private List<Cuenta> listaCuenta;

        public CuentasController()
        {
            cuentasDAO = new CuentasDAO();
        }

        public List<Cuenta> getList()
        {
            return cuentasDAO.getList();
        }

        public bool insert(Cuenta cuenta)
        {
            this.estado = this.cuentasDAO.insert(cuenta);
            return this.estado;
        }

        public bool agregarListaDeCuentas(List<Cuenta> listCuentas)
        {
            this.estado = this.cuentasDAO.agregarListaDeCuentas(listCuentas);
            return this.estado;
        }

        public List<Cuenta> listaNivelTipo(int nivel, string tipo)
        {
            this.lista = this.cuentasDAO.listaNivelTipo(nivel, tipo);

            return this.lista;
        }

        public List<Cuenta> listaNivel(int nivel)
        {
            this.lista = this.cuentasDAO.listaNivel(nivel);

            return this.lista;
        }

        public bool update(Cuenta cuenta)
        {
            return this.cuentasDAO.update(cuenta);
        }

        public bool delete(int idCuenta)
        {
            return this.cuentasDAO.delete(idCuenta);
        }

    }
}
