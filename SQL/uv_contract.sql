ALTER VIEW uv_contract
AS
SELECT 
    c.Contract_ID,
    c.Contract_No,
    c.Contract_Date,
    c.Contract_Recognizance,
    c.Contract_Status,
    s.Name AS Contract_StatusName,
    c.Contract_Type,
    t.Name AS Contract_TypeName,
    c.Date_Checkin,
    c.Date_Checkout,
    c.room_price,
    c.Renter_ID,
    rent.RenterFullname,
    rent.Renter_Card,
    rent.Renter_Address,
    rent.Renter_Tel,
    rent.Renter_Nationality,
    c.Room_ID,
    room.Room_number,
    room.Room_floor,
    room.RoomType,
    room.RoomStatus
FROM tblContract c
INNER JOIN tblStatus t ON c.Contract_Type = t.StatusID
INNER JOIN tblStatus s ON c.Contract_Status = s.StatusID
INNER JOIN uv_renter rent ON c.Renter_ID = rent.Renter_ID
INNER JOIN uv_room room ON c.Room_ID = room.Room_ID
