ALTER VIEW uv_payment
AS
select 
    p.Pay_ID,
    p.Contract_ID,
    p.Pay_date,
    c.Contract_No,
    c.Room_number,
    c.Room_floor,
    c.RenterFullname,
    c.Contract_Recognizance,
    c.room_price,
    c.Contract_Type,
    c.Contract_TypeName,
    c.Date_Checkin,
    c.Date_Checkout,
    p.Pay_status,
    p.Pay_Sum_amount,
    s.Name AS PaymentStatus
from tblPayment p
INNER JOIN tblStatus s ON p.Pay_status = s.StatusID
INNER JOIN uv_contract c ON p.Contract_ID = c.Contract_ID


