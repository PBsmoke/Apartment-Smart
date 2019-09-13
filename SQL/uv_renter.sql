CREATE VIEW uv_renter
AS
SELECT 
    r.Renter_ID,
    r.Renter_TitleName,
    r.Renter_Name,
    r.Renter_Lastname,
    r.Renter_Nationality,
    r.Renter_Card,
    r.Renter_Tel,
    r.Renter_Address,
    r.Renter_TitleName + ' ' + r.Renter_Name + ' ' + r.Renter_Lastname  AS RenterFullName
FROM tblRenter r