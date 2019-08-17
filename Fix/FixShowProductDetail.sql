IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'uv_ProductDT'))
DROP VIEW uv_ProductDT
GO

CREATE VIEW uv_ProductDT
AS
SELECT
tblProduct.ProductID, 
tblProduct.ProductTypeID, 
tblProduct.ProductCode,  
tblProduct.ProductName, 
tblProduct.ProductNameEng, 
tblProductType.ProductTypeName,
tblProduct.ProductCost,
tblProduct.ProductPrice, 
tblProduct.ProductTotal/ tblProductUnitDT.TotalofUnit AS ProductTotal, 
tblProduct.ProductLimit1, 
tblProduct.ProductLimit2,
tblProduct.Remark,
tblProductUnitDT.ProductUnitDT, 
tblProductUnitDT.UnitID,
tblUnit.UnitName,
tblProductUnitDT.TotalofUnit,
tblProductUnitDT.Listno, 
tblProductUnitDT.Price, 
tblProductUnitDT.Barcode
FROM tblProduct
LEFT JOIN tblProductType ON tblProduct.ProductTypeID = tblProductType.ProductTypeID
LEFT JOIN tblProductUnitDT ON tblProduct.ProductID = tblProductUnitDT.ProductID
LEFT JOIN tblUnit ON tblProductUnitDT.UnitID = tblUnit.UnitID

GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'uv_SaleforTax'))
DROP VIEW uv_SaleforTax
GO

CREATE VIEW uv_SaleforTax  
AS  
SELECT          
 tblSale.SaleID,   
 tblSale.SaleDocno,   
 tblSale.SaleDate,   
 tblSale.SaleStatus,   
 tblSale.EmpID,   
 tblSale.CusID,   
 tblSale.SumPrice,   
 tblSale.SumDiscount,   
 tblSale.SumPay,   
 tblSale.SumRemain,   
 tblSale.SumTotal,   
 ISNULL(tblSale.SumTax,0) AS SumTax,  
 tblSale.SumTotal  AS SumNet,  
 tblSale.Remark,    
 uv_Customer.CusCode,   
 uv_Customer.CusName,  
 uv_Customer.CusTaxID  
FROM tblSale    
LEFT OUTER JOIN uv_Customer ON tblSale.CusID = uv_Customer.CusID   