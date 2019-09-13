CREATE VIEW uv_room 
AS
SELECT  
    r.Room_ID,
    r.Room_number,
    r.Room_floor,
    r.Room_Type,
    t.Name AS RoomType,
    r.Room_Price_daily,
    r.Room_Price_monthly,
    r.Room_status,
    s.Name AS RoomStatus
FROM tblRoom r
INNER JOIN tblStatus s ON r.Room_status = s.StatusID
INNER JOIN tblStatus t ON r.Room_Type = t.StatusID