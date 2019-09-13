ALTER VIEW uv_record_detail
AS
SELECT 
    r.*,
    rdt.RecordDT_ID,
    rdt.Contract_ID,
    rdt.Num_Water,
    rdt.Before_Power,
    rdt.Num_Power,
    rdt.Record_water,
    rdt.Record_power,
    rdt.Record_date,
    c.room_price,
    c.RenterFullname,
    c.Room_number
FROM tblRecord r
LEFT JOIN tblRecordDT rdt ON r.Record_ID = rdt.Record_ID
INNER JOIN uv_contract c ON rdt.Contract_ID = c.Contract_ID