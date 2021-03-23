print("Adding MongoDriverTest collections");

db = db.getSiblingDB(env + "-MongoDriverTest");
db.createCollection("User");
var userCollection = db.getCollection("User");

try {
   userCollection.insertMany( [
{ "_id": NUUID("561FC9B6-74AB-D604-337F-3D83F8504E01"), "Email": "dumy@yahoo.com", "Password": "asdas8757as78fdsgh98hb8sad89a", "State": true, "Type": 1, "CreationDate": ISODate("2021-03-20T11:06:16.266Z"), "Owner": true },
 { "_id": NUUID("E5C24E7A-A819-1E62-E37C-0700402A1B8C"), "Email": "dumy2@yahoo.com", "Password": "asdas8757as78fdsgh98hb8sad89a", "State": false, "Type": 1, "CreationDate": ISODate("2021-03-20T11:06:16.266Z"), "Owner": false },
 { "_id": NUUID("CEBF5C68-9DAB-3590-3E11-E01DFEE0CAB7"), "Email": "dumy3@yahoo.com", "Password": "asdas8757as78fdsgh98hb8sad89a", "State": false, "Type": 1, "CreationDate": ISODate("2021-03-20T11:06:16.266Z"), "Owner": true },
 { "_id": NUUID("6DEB815A-5F4B-D7A5-8571-168AB1DA8E67"), "Email": "dumy4@yahoo.com", "Password": "asdas8757as78fdsgh98hb8sad89a", "State": true, "Type": 1, "CreationDate": ISODate("2021-03-20T11:06:16.266Z"), "Owner": true },
 { "_id": NUUID("7FF26F6F-CA03-FD5B-993C-CB0F2FD6F9B8"), "Email": "dumy5@yahoo.com", "Password": "asdas8757as78fdsgh98hb8sad89a", "State": true, "Type": 1, "CreationDate": ISODate("2021-03-20T11:06:16.266Z"), "Owner": true },
 { "_id": NUUID("5588EDAA-8B4A-21EC-6E09-AC366C60BE28"), "Email": "dumy6@yahoo.com", "Password": "asdas8757as78fdsgh98hb8sad89a", "State": false, "Type": 1, "CreationDate": ISODate("2021-03-20T11:06:16.266Z"), "Owner": false },
 { "_id": NUUID("07C379FB-E86E-672E-2AEF-A51D972B23DD"), "Email": "dumy7@yahoo.com", "Password": "asdas8757as78fdsgh98hb8sad89a", "State": true, "Type": 3, "CreationDate": ISODate("2021-03-20T11:06:16.266Z"), "Owner": true },
 { "_id": NUUID("6744521B-D152-D609-73CB-BC6FDABD82E8"), "Email": "dumy8@yahoo.com", "Password": "asdas8757as78fdsgh98hb8sad89a", "State": true, "Type": 1, "CreationDate": ISODate("2021-03-20T11:06:16.266Z"), "Owner": false },
 { "_id": NUUID("A1685337-572A-497B-0D73-1384E453D3B4"), "Email": "dumy9@yahoo.com", "Password": "asdas8757as78fdsgh98hb8sad89a", "State": true, "Type": 2, "CreationDate": ISODate("2021-03-20T11:06:16.266Z"), "Owner": true },
 { "_id": NUUID("978211D7-76EB-B5E4-C14B-CFDD78BF0AF2"), "Email": "dumy10@yahoo.com", "Password": "asdas8757as78fdsgh98hb8sad89a", "State": true, "Type": 1, "CreationDate": ISODate("2021-03-20T11:06:16.266Z"), "Owner": false }
   ] );
} catch (e) {
   print (e);
}
