﻿alter PROC GetRevenueDaily
	@fromDate VARCHAR(10),
	@toDate VARCHAR(10)
AS
BEGIN
		  select
                CAST(b.DateCreated AS DATE) as Date,
                sum(bd.Quantity*bd.Price) as Revenue,
                sum((bd.Quantity*bd.Price)-(bd.Quantity * p.OriginalPrice)) as Profit
                from Bills b
                inner join dbo.BillDetails bd
                on b.Id = bd.BillId
                inner join Products p
                on bd.ProductId  = p.Id
                where b.DateCreated <= cast(@toDate as date) 
				AND b.DateCreated >= cast(@fromDate as date)
                group by b.DateCreated
END

EXEC dbo.GetRevenueDaily @fromDate = '11/09/2021',
                         @toDate = '11/10/2022' 