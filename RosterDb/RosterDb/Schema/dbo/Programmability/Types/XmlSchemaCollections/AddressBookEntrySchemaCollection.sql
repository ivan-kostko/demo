CREATE XML SCHEMA COLLECTION [dbo].[AddressBookEntrySchemaCollection]
AS N'<?xml version="1.0" encoding="utf-16"?>
<xs:schema attributeFormDefault="unqualified" elementFormDefault="qualified" xmlns:xs="http://www.w3.org/2001/XMLSchema">
  <xs:element name="address_book_entry">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs="unbounded" name="row">
          <xs:complexType>
            <xs:attribute name="Email" type="xs:string" use="optional" />
            <xs:attribute name="Some_contact_data1" type="xs:string" use="optional" />
            <xs:attribute name="Some_contact_data2" type="xs:string" use="optional" />
            <xs:attribute name="Some_contact_data3" type="xs:string" use="optional" />
            <xs:attribute name="Contact_name" type="xs:string" use="optional" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>'
