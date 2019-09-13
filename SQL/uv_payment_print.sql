CREATE VIEW uv_payment_print
AS
SELECT 
    uv.*,
    dt.PayDT_ID,
    dt.Detail,
    dt.Amount 
FROM uv_payment uv
LEFT JOIN tblPaymentDT dt ON uv.Pay_ID = dt.Pay_ID