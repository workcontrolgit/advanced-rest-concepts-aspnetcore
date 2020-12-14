using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace AccountOwnerServer.Controllers
{
	/// <summary>
	/// AccountController
	/// </summary>
	[Route("api/owners/{ownerId}/accounts")]
	[ApiController]
	
	public class AccountController : ControllerBase
	{
		private ILoggerManager _logger;
		private IRepositoryWrapper _repository;
		/// <summary>
		/// AccountController
		/// </summary>
		/// <param name="logger"></param>
		/// <param name="repository"></param>
		public AccountController(ILoggerManager logger,
			IRepositoryWrapper repository)
		{
			_logger = logger;
			_repository = repository;
		}
		/// <summary>
		/// GetAccountsForOwner
		/// </summary>
		/// <param name="ownerId"></param>
		/// <param name="parameters"></param>
		/// <returns></returns>
		[HttpGet]
		public IActionResult GetAccountsForOwner(Guid ownerId, [FromQuery] AccountParameters parameters)
		{
			var accounts = _repository.Account.GetAccountsByOwner(ownerId, parameters);

			var metadata = new
			{
				accounts.TotalCount,
				accounts.PageSize,
				accounts.CurrentPage,
				accounts.TotalPages,
				accounts.HasNext,
				accounts.HasPrevious
			};

			Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

			_logger.LogInfo($"Returned {accounts.TotalCount} accounts from database.");

			return Ok(accounts);
		}
		/// <summary>
		/// GetAccountForOwner
		/// </summary>
		/// <param name="ownerId"></param>
		/// <param name="id"></param>
		/// <param name="fields"></param>
		/// <returns></returns>
		[HttpGet("{id}")]
		public IActionResult GetAccountForOwner(Guid ownerId, Guid id, [FromQuery] string fields)
		{
			var account = _repository.Account.GetAccountByOwner(ownerId, id, fields);

			if (account == default(Entity))
			{
				_logger.LogError($"Account with id: {id}, hasn't been found in db.");
				return NotFound();
			}

			return Ok(account);
		}
	}
}
