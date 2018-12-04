using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Presentation.Models;
using Projeto.Entities;
using Projeto.Repository.Persistence;
using System.Collections;
using System.Net;
using System.Text;



//Controllers recebe requisições da views , os dados enviados pelas Models
//e realiza o processamento da aplicação..

namespace Projeto.Presentation.Controllers
{
    public class ClienteController : Controller
    {


        // GET: Cliente/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: Cliente/Consulta
        public ActionResult Consulta()
        {
            return View();
        }


        // usamos nos métodos nas classes de controle  que transmitem dados em JSON..

        //JsonResult -> Receber chamadas Ajax (JavaScript)
        public JsonResult CadastrarCliente(ClienteCadastroViewModel model)
        {
            // verificar se os dados model passaram nas validacoes..
            if (ModelState.IsValid)
            {
                try
                {
                    // entidade..
                    Cliente c = new Cliente();
                    c.Nome = model.Nome;
                    c.Endereco = model.Endereco;
                    c.CEP = model.CEP;
                    c.Bairro = model.Bairro;
                    c.Cidade = model.Cidade;
                    c.UF = model.UF;
                    c.Telefone = model.Telefone;
                    c.Email = model.Email;


                    //gravar no banco..
                    ClienteRepository rep = new ClienteRepository();
                    rep.Insert(c);

                    return Json($"Cliente {c.Nome}, cadastrado com sucesso.");
                }
                catch (Exception e)
                {
                    //retornar mensagem de erro..
                    return Json(e.Message);
                    
                }
            }
            else
            {
                //criar uma rotina para retornar as mensagens de erro de 
                //validacao para cada campo da classe viewmodel..
                Hashtable erros = new Hashtable();

                //varrer o objeto ModelState..
                foreach(var state in ModelState)
                {
                    //verificar se o elemento contem erro..
                    if (state.Value.Errors.Count > 0)
                    {
                        //adicionar o erro dentro do Hashtable..
                        erros[state.Key] = state.Value.Errors.Select(e => e.ErrorMessage).First();
                    }
                }


                // retornar erros de Validação.. Status 400
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(erros);
            }
        }

        //método para retornar a consulta de cliente para o Angular..
        public JsonResult ConsultarClientes()
        {
            try
            {
                //declarar uma lista da classe clienteConsultaViewModel..
                List<ClienteConsultaViewModel> lista = new List<ClienteConsultaViewModel>();

                //varrer cada  abtido do banco de dados
                ClienteRepository rep = new ClienteRepository();
                foreach(Cliente c in rep.FindAll())
                {
                    ClienteConsultaViewModel model = new ClienteConsultaViewModel();
                    model.IdCliente = c.IdCliente;
                    model.Nome = c.Nome;
                    model.Endereco = c.Endereco;
                    model.CEP = c.CEP;
                    model.Bairro = c.Bairro;
                    model.Cidade = c.Cidade;
                    model.UF = c.UF;
                    model.Telefone = c.Telefone;
                    model.Email = c.Email;

                    lista.Add(model); //adicionando na lista..
                }

                //retornando a lista
                return Json(lista, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                //retornar erro..
                return Json(e.Message, JsonRequestBehavior.AllowGet);
            }
       }

        //método para retornar  1 cliente pelo id..
        public JsonResult ObterCliente(int idCliente)
        {
            try
            {
                //buscar 1 cliente no banco de dados pelo id..
                ClienteRepository rep = new ClienteRepository();
                Cliente c = rep.FindById(idCliente);

                //retornando para a página..
                ClienteConsultaViewModel model = new ClienteConsultaViewModel();
                model.IdCliente = c.IdCliente;
                model.Nome = c.Nome;
                model.Endereco = c.Endereco;
                model.CEP = c.CEP;
                model.Bairro = c.Bairro;
                model.Cidade = c.Cidade;
                model.UF = c.UF;
                model.Telefone = c.Telefone;
                model.Email = c.Email;

                //enviando para a página..
                return Json(model, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                //retornar mensagem de erro..
                return Json(e.Message, JsonRequestBehavior.AllowGet);
            }
        }



        //metodo para excluir um cliente..
        public JsonResult ExcluirCliente(int idCliente)
        {
            try
            {
                //buscar o motorista na base de dados pelo id..
                ClienteRepository rep = new ClienteRepository();
                

                    Cliente c = rep.FindById(idCliente);

                    //excluindo o cliente..
                    rep.Delete(c);

                    //retornando mensagem de sucesso..
                    return Json($"Cliente {c.Nome}, excluído com sucesso.",
                    JsonRequestBehavior.AllowGet);

              
                
            }
            catch (Exception e)
            {

                return Json(e.Message, JsonRequestBehavior.AllowGet);
            }
        }




        //método para atualizar ..
        public JsonResult AtualizarCliente(ClienteEdicaoViewModel model)
        {
            try
            {
                //criando um objeto da classe de entidade..
                Cliente c = new Cliente();
                c.IdCliente = model.IdCliente;
                c.Nome = model.Nome;
                c.Endereco = model.Endereco;
                c.CEP = model.CEP;
                c.Bairro = model.Bairro;
                c.Cidade = model.Cidade;
                c.UF = model.UF;
                c.Telefone = model.Telefone;
                c.Email = model.Email;

                ClienteRepository rep = new ClienteRepository();
                rep.Update(c); //atualizando..

                return Json($"Cliente {c.Nome}, atualizado com sucesso.");
            }
            catch (Exception e)
            {

                return Json(e.Message);
            }
        }

           
    }
    
}