CREATE VIEW uv_record
AS
SELECT * FROM tblRecord r
INNER JOIN tblStatus s ON r.RecordStatus = s.StatusID

