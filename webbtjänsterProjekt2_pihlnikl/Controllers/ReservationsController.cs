using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webbtjänsterProjekt2_pihlnikl.Models;

namespace webbtjänsterProjekt2_pihlnikl.Controllers
{
    [Route("reservations")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                SqlConnection sql = new SqlConnection("Server = tcp:pihlnikl.database.windows.net,1433; Initial Catalog = projekt2_pihlnikl; Persist Security Info = False; User ID = pihlnikl; Password =Salasana-741; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
                sql.Open();

                IEnumerable<Reservation> reservations = sql.Query<Reservation>("SELECT * FROM Reservations");
                sql.Close();

                return StatusCode(200, reservations);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

       /* [HttpGet("{owner}", Name = "GetReservation")]
        public IActionResult Get(string owner)
        {
            try
            {
                SqlConnection sql = new SqlConnection("Server = tcp:pihlnikl.database.windows.net,1433; Initial Catalog = projekt2_pihlnikl; Persist Security Info = False; User ID = pihlnikl; Password =Salasana-741; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
                sql.Open();

                IEnumerable<Reservation> reservations = sql.Query<Reservation>("SELECT * FROM Reservations WHERE owner = " + owner);
                sql.Close();

                return StatusCode(200, reservations);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        } */

        [HttpPost]
        public IActionResult Post([FromBody] Reservation reservation)
        {
            try
            {
                SqlConnection sql = new SqlConnection("Server = tcp:pihlnikl.database.windows.net,1433; Initial Catalog = projekt2_pihlnikl; Persist Security Info = False; User ID = pihlnikl; Password =Salasana-741; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
                sql.Open();

                string Query = "INSERT INTO Reservations (cabinId,services,dates) VALUES(@cabinId, @services, @dates)";
                sql.Query(Query, reservation);

                sql.Close();

                return StatusCode(201, reservation);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Reservation reservation)
        {
            try
            {
                SqlConnection sql = new SqlConnection("Server = tcp:pihlnikl.database.windows.net,1433; Initial Catalog = projekt2_pihlnikl; Persist Security Info = False; User ID = pihlnikl; Password =Salasana-741; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
                sql.Open();

                string Query = "UPDATE Reservations SET cabinId = @cabinId, services = @services, dates = @dates WHERE id = " + id;
                sql.Query(Query, reservation);
                sql.Close();

                return StatusCode(200);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                SqlConnection sql = new SqlConnection("Server = tcp:pihlnikl.database.windows.net,1433; Initial Catalog = projekt2_pihlnikl; Persist Security Info = False; User ID = pihlnikl; Password =Salasana-741; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
                sql.Open();

                string Query = "DELETE FROM Reservations WHERE id = " + id;
                sql.Query(Query);

                sql.Close();

                return StatusCode(200);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
