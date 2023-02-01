INSERT INTO Brands(Id, Name, Slug, IsPublished, CreatedOn, LatestUpdatedOn, IsDeleted) VALUES
(cast('EE00DDE2-9E30-475D-8A9A-3DFE6173FB30' as uniqueidentifier), 'Lenovo', 'lenovo', 1, GETDATE(), GETDATE(), 0),
(cast('148DF6D1-65C1-4E00-B664-5F0A461160A9' as uniqueidentifier), 'Apple', 'apple', 1, GETDATE(), GETDATE(), 0),
(CAST('8AC1A1A5-6CDC-48AD-9292-89E912A6A80A' as uniqueidentifier), 'Nokia', 'nokia', 1, GETDATE(), GETDATE(), 0),
(CAST('7CC391E1-8783-4F92-A0CC-9271B34C9EA8' as uniqueidentifier), 'Samsung', 'samsung', 1, GETDATE(), GETDATE(), 0),
(CAST('B9FB2C43-BEE6-43DE-8996-9F39E444FAC0' as uniqueidentifier), 'Hp', 'hp', 1, GETDATE(), GETDATE(), 0),
(CAST('B2647F68-1529-44B5-8B2E-E2F4E969D2A7' as uniqueidentifier), 'Dell', 'dell', 1, GETDATE(), GETDATE(), 0)

GO

INSERT INTO Categories(Id, Name, Slug, IsPublished, IncludeInMenu, DisplayOrder, ParentId, CreatedOn, LatestUpdatedOn, IsDeleted) VALUES
(CAST('8AC51586-431D-4642-8435-5926CB6C04F4' as uniqueidentifier), 'Accessories', 'accessories', 1, 1, 0, NULL, GETDATE(), GETDATE(), 0),
(CAST('C3F05C5C-3FA3-4C6D-81C8-E33526E39511' as uniqueidentifier), 'Cables', 'cables', 1, 1, 0, CAST('8AC51586-431D-4642-8435-5926CB6C04F4' as uniqueidentifier), GETDATE(), GETDATE(), 0),
(CAST('D8C4A2D8-3F4D-4D3C-923C-F4F46482AB7A' as uniqueidentifier), 'Headphones', 'headphones', 1, 1, 0, CAST('8AC51586-431D-4642-8435-5926CB6C04F4' as uniqueidentifier), GETDATE(), GETDATE(), 0),
(CAST('633B7E0D-E227-450E-A3A2-574125AA6024' as uniqueidentifier), 'USB Drives', 'usb-drives', 1, 1, 0, CAST('8AC51586-431D-4642-8435-5926CB6C04F4' as uniqueidentifier), GETDATE(), GETDATE(), 0),

(CAST('F64602E6-D373-42EF-A3BE-4360449BADA1' as uniqueidentifier), 'Computers', 'computers', 1, 1, 0, NULL, GETDATE(), GETDATE(), 0),
(CAST('ACFB3C87-502B-44A0-B39B-6B644C57FFB6' as uniqueidentifier), 'Gaming', 'gaming', 1, 1, 0, CAST('F64602E6-D373-42EF-A3BE-4360449BADA1' as uniqueidentifier), GETDATE(), GETDATE(), 0),
(CAST('761D55DA-023C-41E0-ACE7-C7316602E0F6' as uniqueidentifier), 'MacBook', 'macbook', 1, 1, 0, CAST('F64602E6-D373-42EF-A3BE-4360449BADA1' as uniqueidentifier), GETDATE(), GETDATE(), 0),

(CAST('7E226ECB-6FC1-4602-BF0B-D14D02A14555' as uniqueidentifier), 'Phones', 'phones', 1, 1, 0, NULL, GETDATE(), GETDATE(), 0),
(CAST('09D370A0-27E9-4B9B-BCF6-B5F076C70F07' as uniqueidentifier), 'Iphone', 'iphone', 1, 1, 0, CAST('7E226ECB-6FC1-4602-BF0B-D14D02A14555' as uniqueidentifier), GETDATE(), GETDATE(), 0),
(CAST('A5924453-4608-427F-9751-717F217EA569' as uniqueidentifier), 'Basic Phones', 'basic-phones', 1, 1, 0, CAST('7E226ECB-6FC1-4602-BF0B-D14D02A14555' as uniqueidentifier), GETDATE(), GETDATE(), 0),
(CAST('D5F3B0E4-350D-4188-A0D1-28EBC5CC3AEA' as uniqueidentifier), 'Gaming', 'gaming', 1, 1, 0, CAST('7E226ECB-6FC1-4602-BF0B-D14D02A14555' as uniqueidentifier), GETDATE(), GETDATE(), 0)

GO

INSERT INTO ProductAttributeGroups(Id, Name) VALUES
(CAST('206E76F1-1F4D-4C0B-84B2-38431548EA49' as uniqueidentifier), 'Platform'),
(CAST('B8DD305A-ABF7-41F1-83FE-3AB7432926C9' as uniqueidentifier), 'Main Camera'),
(CAST('58B6906E-8589-42CA-8D8E-EA85867D4CB7' as uniqueidentifier), 'Selfie Camera'),
(CAST('4D6E8118-5CF2-4DE6-BA04-3CF53425F910' as uniqueidentifier), 'Features'),
(CAST('A900D061-715E-4682-B493-4A3F75F95B01' as uniqueidentifier), 'Sound'),
(CAST('99BAB448-5D08-4EB1-98CE-5784A8DFFBCC' as uniqueidentifier), 'Body'),
(CAST('3673D751-C834-45A2-9416-6053581922B4' as uniqueidentifier), 'General'),
(CAST('1AC2765D-43C9-49B6-8088-876AD2E9B712' as uniqueidentifier), 'Connectivity'),
(CAST('5CDD890A-F6B8-406E-A054-B608BAA85C70' as uniqueidentifier), 'Memory'),
(CAST('646DCEEE-5ECA-46A0-8A5F-DB8D280DAB4A' as uniqueidentifier), 'Display'),
(CAST('FD3426A4-D80F-4F85-9C71-FDA22E71C662' as uniqueidentifier), 'Battery')

GO

INSERT INTO ProductAttributes(Id, GroupId, Name) VALUES
(CAST('45F254D5-7658-490C-B7C5-1895C04DAA86' as uniqueidentifier), CAST('3673D751-C834-45A2-9416-6053581922B4' as uniqueidentifier), 'Announced'),

(CAST('6DDA4BD4-538C-4A56-BB9A-804E4E477456' as uniqueidentifier), CAST('206E76F1-1F4D-4C0B-84B2-38431548EA49' as uniqueidentifier), 'CPU'),
(CAST('18BBCB21-0C25-4543-AF2A-B855E87E01F4' as uniqueidentifier), CAST('206E76F1-1F4D-4C0B-84B2-38431548EA49' as uniqueidentifier), 'OS'),
(CAST('022C909E-BCF6-40CE-A490-E781557B9B96' as uniqueidentifier), CAST('206E76F1-1F4D-4C0B-84B2-38431548EA49' as uniqueidentifier), 'GPU'),
(CAST('0993DC9D-38B9-4C9A-A315-EC6E63A540EA' as uniqueidentifier), CAST('206E76F1-1F4D-4C0B-84B2-38431548EA49' as uniqueidentifier), 'Chipset'),

(CAST('74D4F4B8-64F7-46EE-9C15-3EE3743514BF' as uniqueidentifier), CAST('B8DD305A-ABF7-41F1-83FE-3AB7432926C9' as uniqueidentifier), 'Modules'),
(CAST('7D637BDF-7801-40C2-B813-4E3C68A0502B' as uniqueidentifier), CAST('B8DD305A-ABF7-41F1-83FE-3AB7432926C9' as uniqueidentifier), 'Video'),
(CAST('67054B20-DEB6-46DD-9E8F-EDAF0B55A551' as uniqueidentifier), CAST('B8DD305A-ABF7-41F1-83FE-3AB7432926C9' as uniqueidentifier), 'Features'),

(CAST('D2641E35-ADE1-48AC-A660-1FA70C648757' as uniqueidentifier), CAST('58B6906E-8589-42CA-8D8E-EA85867D4CB7' as uniqueidentifier), 'Video'),
(CAST('EAAE84DE-3092-4E5B-ADF4-98260ED31B39' as uniqueidentifier), CAST('58B6906E-8589-42CA-8D8E-EA85867D4CB7' as uniqueidentifier), 'Modules'),
(CAST('9F898DBD-1C78-4890-BA23-A2703DEF84F6' as uniqueidentifier), CAST('58B6906E-8589-42CA-8D8E-EA85867D4CB7' as uniqueidentifier), 'Features'),

(CAST('61EF7843-0D3A-4F3E-8F75-CFA2F9C366D4' as uniqueidentifier), CAST('4D6E8118-5CF2-4DE6-BA04-3CF53425F910' as uniqueidentifier), 'Sensors'),

(CAST('91995FC8-087C-42B5-989F-02738205C09C' as uniqueidentifier), CAST('A900D061-715E-4682-B493-4A3F75F95B01' as uniqueidentifier), '3.5mm jack'),
(CAST('B627C3B1-48DA-4A10-8E84-436532E3CF1E' as uniqueidentifier), CAST('A900D061-715E-4682-B493-4A3F75F95B01' as uniqueidentifier), 'Loudspeaker'),

(CAST('3A79F080-A507-4016-89FE-608EF1A41E88' as uniqueidentifier), CAST('99BAB448-5D08-4EB1-98CE-5784A8DFFBCC' as uniqueidentifier), 'SIM'),
(CAST('D9D56DA3-BF2A-4FA0-957C-C6E586A99400' as uniqueidentifier), CAST('99BAB448-5D08-4EB1-98CE-5784A8DFFBCC' as uniqueidentifier), 'Weight'),
(CAST('35E47E74-1D9A-4F8A-AF64-DFAB49030BB5' as uniqueidentifier), CAST('99BAB448-5D08-4EB1-98CE-5784A8DFFBCC' as uniqueidentifier), 'Build'),
(CAST('4DDAC538-909E-4E06-ACC9-E0763D7C59D4' as uniqueidentifier), CAST('99BAB448-5D08-4EB1-98CE-5784A8DFFBCC' as uniqueidentifier), 'Dimensions'),

(CAST('BC9A2A55-FA69-4526-AA89-07A3B5B748BC' as uniqueidentifier), CAST('5CDD890A-F6B8-406E-A054-B608BAA85C70' as uniqueidentifier), 'Internal'),
(CAST('79BBA792-9E11-44FA-842C-D2CA0919AB75' as uniqueidentifier), CAST('5CDD890A-F6B8-406E-A054-B608BAA85C70' as uniqueidentifier), 'Card slot'),

(CAST('72BA299F-9AB6-4429-B083-1C673811672F' as uniqueidentifier), CAST('646DCEEE-5ECA-46A0-8A5F-DB8D280DAB4A' as uniqueidentifier), 'Type'),
(CAST('75CF4E98-7BA8-4190-98C9-2086D1B90A63' as uniqueidentifier), CAST('646DCEEE-5ECA-46A0-8A5F-DB8D280DAB4A' as uniqueidentifier), 'Protection'),
(CAST('841DE7A5-82CE-4F64-AEB2-23E1EA70DD2B' as uniqueidentifier), CAST('646DCEEE-5ECA-46A0-8A5F-DB8D280DAB4A' as uniqueidentifier), 'Resolution'),
(CAST('D8ECB7AE-6539-4FD9-9F72-51A37BA754C4' as uniqueidentifier), CAST('646DCEEE-5ECA-46A0-8A5F-DB8D280DAB4A' as uniqueidentifier), 'Size'),

(CAST('C50D9A30-E567-4553-85DB-7BB40125433F' as uniqueidentifier), CAST('1AC2765D-43C9-49B6-8088-876AD2E9B712' as uniqueidentifier), 'Bluetooth'),
(CAST('3A95802A-B1FB-4CA6-88C1-87448981A019' as uniqueidentifier), CAST('1AC2765D-43C9-49B6-8088-876AD2E9B712' as uniqueidentifier), 'USB'),
(CAST('522FFA4D-D907-43E2-BB23-96FA7FEF24B1' as uniqueidentifier), CAST('1AC2765D-43C9-49B6-8088-876AD2E9B712' as uniqueidentifier), '3G'),
(CAST('600FA0C8-D3DE-4C78-9E2E-0B79D2A794F1' as uniqueidentifier), CAST('1AC2765D-43C9-49B6-8088-876AD2E9B712' as uniqueidentifier), 'WLAN'),
(CAST('C3F8CD5F-168D-4F4D-ADA3-1344CB7E75E7' as uniqueidentifier), CAST('1AC2765D-43C9-49B6-8088-876AD2E9B712' as uniqueidentifier), 'Positioning'),
(CAST('52832EB3-A80E-4828-B0EC-19B458FE1DF7' as uniqueidentifier), CAST('1AC2765D-43C9-49B6-8088-876AD2E9B712' as uniqueidentifier), 'NFC'),
(CAST('409F8969-4650-4B2F-94F0-A5BDFF20CA0C' as uniqueidentifier), CAST('1AC2765D-43C9-49B6-8088-876AD2E9B712' as uniqueidentifier), '5G'),
(CAST('11D6F0D6-D9BC-4B33-897A-BC66E6B8BF5D' as uniqueidentifier), CAST('1AC2765D-43C9-49B6-8088-876AD2E9B712' as uniqueidentifier), 'Infrared port'),
(CAST('F60DA4E8-2D75-4A5D-B6D1-EAD215939720' as uniqueidentifier), CAST('1AC2765D-43C9-49B6-8088-876AD2E9B712' as uniqueidentifier), 'Radio'),
(CAST('99E02E27-604B-4487-A6EE-FEF0DFD90051' as uniqueidentifier), CAST('1AC2765D-43C9-49B6-8088-876AD2E9B712' as uniqueidentifier), '4G'),

(CAST('80BBADDC-4D0A-44C7-BCE0-041BA78139F9' as uniqueidentifier), CAST('FD3426A4-D80F-4F85-9C71-FDA22E71C662' as uniqueidentifier), 'Type'),
(CAST('7B314B22-4695-4140-9861-E44D08624052' as uniqueidentifier), CAST('FD3426A4-D80F-4F85-9C71-FDA22E71C662' as uniqueidentifier), 'Charging')

GO

INSERT INTO Medias(Id, Caption, FileSize, FileName, MediaType, CreatedOn, LatestUpdatedOn, IsDeleted) VALUES
(CAST('3609A9BA-8552-49E7-BA94-3FE4EF689C8A' as uniqueidentifier), NULL, 100, '81b606ea-0bb0-4cea-a9d7-6406175df9bb.jpg', 1, GETDATE(), GETDATE(), 0),
(CAST('D42D97CF-8470-4FCE-99B2-85FF4D0B3996' as uniqueidentifier), NULL, 100, '89374e88-b14c-4d38-b5cd-eacdc5ce3015.jpg', 1, GETDATE(), GETDATE(), 0),
(CAST('94E57AAC-1E2C-44F0-824F-986CAACD8D7B' as uniqueidentifier), NULL, 100, '68c7ff8f-014e-46c8-8daa-f35c646cc10a.jpg', 1, GETDATE(), GETDATE(), 0),
(CAST('6BBBA2AD-8DD0-46EB-85D6-B22D3A85823B' as uniqueidentifier), NULL, 100, 'd74fd909-6fe0-4bc3-bf61-86d12dc98a2e.jpg', 1, GETDATE(), GETDATE(), 0),
(CAST('473CDB36-4998-481A-8119-CA2C42C52783' as uniqueidentifier), NULL, 100, 'ffc255b3-07c8-4ee5-94e9-d472c6af3f07.jpg', 1, GETDATE(), GETDATE(), 0)

GO

INSERT INTO Products(Id, Name, Slug, Price, IsCallForPricing, IsAllowToOrder, StockQuantity, IsPublished, DisplayOrder, BrandId, ThumbnailImageId, CreatedOn, LatestUpdatedOn, IsDeleted) VALUES
(CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'iPhone 14 Pro Max', 'iphone-14-pro-max', 1024, 0, 0, 50, 1, 0, CAST('148DF6D1-65C1-4E00-B664-5F0A461160A9' as uniqueidentifier), CAST('6BBBA2AD-8DD0-46EB-85D6-B22D3A85823B' as uniqueidentifier), GETDATE(), GETDATE(), 0),
(CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Samsung Galaxy S22 Ultra 5G', 'samsung-galaxy-s22-ultra-5g', 2048, 0, 0, 50, 1, 0, CAST('7CC391E1-8783-4F92-A0CC-9271B34C9EA8' as uniqueidentifier), CAST('473CDB36-4998-481A-8119-CA2C42C52783' as uniqueidentifier), GETDATE(), GETDATE(), 0)

GO

INSERT INTO ProductAttributeValues(Id, AttributeId, ProductId, Value) VALUES
-- Apple iPhone 14 Pro Max
(CAST('dfc25c73-6f00-43e8-938f-cc42310338ae' as uniqueidentifier), CAST('45F254D5-7658-490C-B7C5-1895C04DAA86' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), '2022, September 07'),

(CAST('81571321-2f2e-4aa5-a648-f94d613dd322' as uniqueidentifier), CAST('6DDA4BD4-538C-4A56-BB9A-804E4E477456' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Hexa-core (2x3.46 GHz Everest + 4x2.02 GHz Sawtooth)'),
(CAST('7313d5e6-6c00-4fdb-af71-3af5a593598b' as uniqueidentifier), CAST('18BBCB21-0C25-4543-AF2A-B855E87E01F4' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'iOS 16, upgradable to iOS 16.3'),
(CAST('fb5c745d-6821-44f8-8bfc-3f59ad44ea7f' as uniqueidentifier), CAST('022C909E-BCF6-40CE-A490-E781557B9B96' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Apple GPU (5-core graphics)'),
(CAST('c0237a00-f71c-4984-a799-6a1054ede58f' as uniqueidentifier), CAST('0993DC9D-38B9-4C9A-A315-EC6E63A540EA' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Apple A16 Bionic (4 nm)'),

(CAST('3fb59467-1b7a-4456-98b5-84992454d9d9' as uniqueidentifier), CAST('74D4F4B8-64F7-46EE-9C15-3EE3743514BF' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), '48 MP, f/1.8, 24mm (wide), 1/1.28", 1.22µm, dual pixel PDAF, sensor-shift OIS'),
(CAST('a4378078-1748-4a61-8ec2-a647550dfcdb' as uniqueidentifier), CAST('7D637BDF-7801-40C2-B813-4E3C68A0502B' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), '4K@24/25/30/60fps, 1080p@25/30/60/120/240fps, 10-bit HDR'),
(CAST('f3844a9b-c4ba-4c30-b9f3-b0e7ca7054e6' as uniqueidentifier), CAST('67054B20-DEB6-46DD-9E8F-EDAF0B55A551' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Dual-LED dual-tone flash, HDR (photo/panorama)'),

(CAST('2e609cf4-4351-4c6d-8c86-bb288596005b' as uniqueidentifier), CAST('D2641E35-ADE1-48AC-A660-1FA70C648757' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), '4K@24/25/30/60fps, 1080p@25/30/60/120fps'),
(CAST('b2573af2-e1ff-4d48-9b20-62f2e1ca669c' as uniqueidentifier), CAST('EAAE84DE-3092-4E5B-ADF4-98260ED31B39' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), '12 MP, f/1.9, 23mm (wide), 1/3.6", PDAF, OIS (unconfirmed)'),
(CAST('a20f76d3-4c1a-41a2-8b1c-f5d47d1f7481' as uniqueidentifier), CAST('9F898DBD-1C78-4890-BA23-A2703DEF84F6' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'HDR, Cinematic mode (4K@24/30fps)'),

(CAST('41250112-7527-4f32-9a33-9a27a81a2559' as uniqueidentifier), CAST('61EF7843-0D3A-4F3E-8F75-CFA2F9C366D4' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Face ID, accelerometer, gyro, proximity, compass, barometer'),

(CAST('da436d7d-893d-429c-9402-6cdf60d49d03' as uniqueidentifier), CAST('91995FC8-087C-42B5-989F-02738205C09C' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'No'),
(CAST('688e1b0f-5082-4cab-81e1-ba823b32d1c9' as uniqueidentifier), CAST('B627C3B1-48DA-4A10-8E84-436532E3CF1E' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Yes, with stereo speakers'),

(CAST('af1bd123-c6e8-4b34-a57e-3f33094f07bf' as uniqueidentifier), CAST('3A79F080-A507-4016-89FE-608EF1A41E88' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Nano-SIM and eSIM - International'),
(CAST('d28542a6-a2f4-4b26-b056-c9fa2efa522f' as uniqueidentifier), CAST('D9D56DA3-BF2A-4FA0-957C-C6E586A99400' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), '240 g (8.47 oz)'),
(CAST('8cf1b681-5a2a-4e1d-8d8b-27c8ab6a7187' as uniqueidentifier), CAST('35E47E74-1D9A-4F8A-AF64-DFAB49030BB5' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Glass front (Corning-made glass), glass back (Corning-made glass), stainless steel frame'),
(CAST('51d48d7f-025d-4d37-9fd2-75a09052c70e' as uniqueidentifier), CAST('4DDAC538-909E-4E06-ACC9-E0763D7C59D4' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), '160.7 x 77.6 x 7.9 mm (6.33 x 3.06 x 0.31 in)'),

(CAST('0884ad2e-81b1-466d-8b01-3475e990fa84' as uniqueidentifier), CAST('BC9A2A55-FA69-4526-AA89-07A3B5B748BC' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), '128GB 6GB RAM, 256GB 6GB RAM, 512GB 6GB RAM, 1TB 6GB RAM'),
(CAST('9ef4022f-507c-4223-9e11-232810583423' as uniqueidentifier), CAST('79BBA792-9E11-44FA-842C-D2CA0919AB75' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'No'),

(CAST('68b136fb-3419-421c-885e-083364cd0ddf' as uniqueidentifier), CAST('72BA299F-9AB6-4429-B083-1C673811672F' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'LTPO Super Retina XDR OLED, 120Hz, HDR10, Dolby Vision, 1000 nits (typ), 2000 nits (HBM)'),
(CAST('32db522f-6ff9-4691-88f3-ebd1a96411b9' as uniqueidentifier), CAST('75CF4E98-7BA8-4190-98C9-2086D1B90A63' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Ceramic Shield glass'),
(CAST('2d726d86-1de8-4204-a17a-7730315509f8' as uniqueidentifier), CAST('841DE7A5-82CE-4F64-AEB2-23E1EA70DD2B' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), '1290 x 2796 pixels, 19.5:9 ratio (~460 ppi density)'),
(CAST('df33d0fc-86ed-49d3-9cd1-b6d1432edbee' as uniqueidentifier), CAST('D8ECB7AE-6539-4FD9-9F72-51A37BA754C4' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), '6.7 inches, 110.2 cm2 (~88.3% screen-to-body ratio)'),

(CAST('cb8a6824-c5c8-4dae-8640-91eebbc14b83' as uniqueidentifier), CAST('C50D9A30-E567-4553-85DB-7BB40125433F' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), '5.3, A2DP, LE'),
(CAST('cc425f97-91c4-4197-8b42-f65efafedb8a' as uniqueidentifier), CAST('3A95802A-B1FB-4CA6-88C1-87448981A019' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Lightning, USB 2.0'),
(CAST('81b538e3-6cce-40cb-8b3d-fc74a0c02d45' as uniqueidentifier), CAST('522FFA4D-D907-43E2-BB23-96FA7FEF24B1' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Yes'),
(CAST('c66cd791-0324-4eab-8b73-41823b97c0b5' as uniqueidentifier), CAST('600FA0C8-D3DE-4C78-9E2E-0B79D2A794F1' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Wi-Fi 802.11 a/b/g/n/ac/6, dual-band, hotspot'),
(CAST('c0aa391c-7fed-4632-89f5-38b14d91e509' as uniqueidentifier), CAST('C3F8CD5F-168D-4F4D-ADA3-1344CB7E75E7' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'GPS (L1+L5), GLONASS, GALILEO, BDS, QZSS'),
(CAST('2ef1b5cc-d752-4a4f-a98d-b5afb83a1517' as uniqueidentifier), CAST('52832EB3-A80E-4828-B0EC-19B458FE1DF7' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Yes'),
(CAST('3f2f7549-7ea8-4fe6-bfa5-9c82a68664ef' as uniqueidentifier), CAST('409F8969-4650-4B2F-94F0-A5BDFF20CA0C' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Yes'),
(CAST('104761b5-2e57-42f2-b3bf-d6053ba9f557' as uniqueidentifier), CAST('11D6F0D6-D9BC-4B33-897A-BC66E6B8BF5D' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'No'),
(CAST('27e730de-877d-4b84-9293-3c2cde3ad0e0' as uniqueidentifier), CAST('F60DA4E8-2D75-4A5D-B6D1-EAD215939720' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'No'),
(CAST('f39e4815-3aef-444d-834c-d544e3a7c71e' as uniqueidentifier), CAST('99E02E27-604B-4487-A6EE-FEF0DFD90051' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Yes'),

(CAST('dd1b7178-af01-45ff-bf68-d1cf4cadc38e' as uniqueidentifier), CAST('80BBADDC-4D0A-44C7-BCE0-041BA78139F9' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Li-Ion 4323 mAh, non-removable (16.68 Wh)'),
(CAST('738b7e96-ceff-4a21-b93f-ba6ea6cbaa2d' as uniqueidentifier), CAST('7B314B22-4695-4140-9861-E44D08624052' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), 'Wired, PD2.0, 50% in 30 min (advertised)'),

-- Samsung Galaxy S22 Ultra 5G
(CAST('eb2ffad9-db6c-4690-87d0-37735f205e8c' as uniqueidentifier), CAST('45F254D5-7658-490C-B7C5-1895C04DAA86' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), '2022, February 09'),

(CAST('4abf11a5-1b63-4e5a-9d0f-18f2c06eaa69' as uniqueidentifier), CAST('6DDA4BD4-538C-4A56-BB9A-804E4E477456' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Octa-core (1x2.8 GHz Cortex-X2 & 3x2.50 GHz Cortex-A710 & 4x1.8 GHz Cortex-A510) - Europe'),
(CAST('a04c17d2-7f99-4c99-8e12-be7c65dfd3cc' as uniqueidentifier), CAST('18BBCB21-0C25-4543-AF2A-B855E87E01F4' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Android 12, upgradable to Android 13, One UI 5'),
(CAST('f9325ec1-d580-4846-9cfd-da70e8587746' as uniqueidentifier), CAST('022C909E-BCF6-40CE-A490-E781557B9B96' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Xclipse 920 - Europe'),
(CAST('de45c963-c688-4b71-968e-51e7fd33a9d5' as uniqueidentifier), CAST('0993DC9D-38B9-4C9A-A315-EC6E63A540EA' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Exynos 2200 (4 nm) - Europe'),

(CAST('d4ffe6d2-b5f2-4d89-8a29-5dbe9abe6d9b' as uniqueidentifier), CAST('74D4F4B8-64F7-46EE-9C15-3EE3743514BF' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), '108 MP, f/1.8, 23mm (wide), 1/1.33", 0.8µm, PDAF, Laser AF, OIS'),
(CAST('f1189432-7d0a-4db5-b6d4-c4d833907811' as uniqueidentifier), CAST('7D637BDF-7801-40C2-B813-4E3C68A0502B' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), '8K@24fps, 4K@30/60fps, 1080p@30/60/240fps, 720p@960fps'),
(CAST('57fb1584-eba3-456e-a649-ac6020f0a1fc' as uniqueidentifier), CAST('67054B20-DEB6-46DD-9E8F-EDAF0B55A551' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'LED flash, auto-HDR, panorama'),

(CAST('97314ad3-e81d-4c3e-9c7b-31eeaecfbbdd' as uniqueidentifier), CAST('D2641E35-ADE1-48AC-A660-1FA70C648757' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), '4K@30/60fps, 1080p@30fps'),
(CAST('5c387e5c-225d-4dbd-bab8-ada76998a3c8' as uniqueidentifier), CAST('EAAE84DE-3092-4E5B-ADF4-98260ED31B39' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), '40 MP, f/2.2, 26mm (wide), 1/2.82'),
(CAST('c1d28b94-237f-4f34-829c-c58d3426c33e' as uniqueidentifier), CAST('9F898DBD-1C78-4890-BA23-A2703DEF84F6' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Dual video call, Auto-HDR'),

(CAST('d7bdcaa5-0a4f-4e0c-a733-dde8d557c6e5' as uniqueidentifier), CAST('61EF7843-0D3A-4F3E-8F75-CFA2F9C366D4' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, barometer'),

(CAST('c7789177-2fae-48c4-b7fc-fd3dce22c793' as uniqueidentifier), CAST('91995FC8-087C-42B5-989F-02738205C09C' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'No'),
(CAST('1285ff55-55dd-4f18-883a-7cdf13866b62' as uniqueidentifier), CAST('B627C3B1-48DA-4A10-8E84-436532E3CF1E' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Yes, with stereo speakers'),

(CAST('7e912183-b47f-4462-ae88-64d8fcda21b8' as uniqueidentifier), CAST('3A79F080-A507-4016-89FE-608EF1A41E88' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Nano-SIM and eSIM or Dual SIM'),
(CAST('6f882e4d-732a-4300-ad52-43dee1b997a9' as uniqueidentifier), CAST('D9D56DA3-BF2A-4FA0-957C-C6E586A99400' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), '228 g / 229 g (mmWave) (8.04 oz)'),
(CAST('80c74fbc-b652-4e97-8e7d-ecb83b97c569' as uniqueidentifier), CAST('35E47E74-1D9A-4F8A-AF64-DFAB49030BB5' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Glass front (Gorilla Glass Victus+), glass back (Gorilla Glass Victus+), aluminum frame'),
(CAST('7ec2095b-5deb-4c57-864c-44aa4fa4a04b' as uniqueidentifier), CAST('4DDAC538-909E-4E06-ACC9-E0763D7C59D4' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), '163.3 x 77.9 x 8.9 mm (6.43 x 3.07 x 0.35 in)'),

(CAST('9f2d2ee3-9f56-44f5-8930-723b05f9ec61' as uniqueidentifier), CAST('BC9A2A55-FA69-4526-AA89-07A3B5B748BC' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), '128GB 6GB RAM, 256GB 6GB RAM, 512GB 6GB RAM, 1TB 6GB RAM'),
(CAST('70a60b25-313d-46df-9f10-caa46189597d' as uniqueidentifier), CAST('79BBA792-9E11-44FA-842C-D2CA0919AB75' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'No'),

(CAST('d20652bb-b895-4857-8598-1a21bf72254f' as uniqueidentifier), CAST('72BA299F-9AB6-4429-B083-1C673811672F' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Dynamic AMOLED 2X, 120Hz, HDR10+, 1750 nits (peak)'),
(CAST('19e06fdb-5b94-41d2-adb2-03a0a317a86c' as uniqueidentifier), CAST('75CF4E98-7BA8-4190-98C9-2086D1B90A63' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Corning Gorilla Glass Victus+'),
(CAST('bde36691-20ca-49c4-b55f-a229a667db66' as uniqueidentifier), CAST('841DE7A5-82CE-4F64-AEB2-23E1EA70DD2B' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), '1440 x 3088 pixels (~500 ppi density)'),
(CAST('d72bce98-5810-423b-8967-6c88f7a61087' as uniqueidentifier), CAST('D8ECB7AE-6539-4FD9-9F72-51A37BA754C4' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), '6.8 inches, 114.7 cm2 (~90.2% screen-to-body ratio)'),

(CAST('92e1cc21-c11b-4f5b-a9d4-66b4d437534e' as uniqueidentifier), CAST('C50D9A30-E567-4553-85DB-7BB40125433F' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), '5.3, A2DP, LE'),
(CAST('d0f8d9f3-a077-46a2-ab57-10541bdfd126' as uniqueidentifier), CAST('3A95802A-B1FB-4CA6-88C1-87448981A019' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'USB Type-C 3.2, OTG'),
(CAST('e9c5ad22-ea67-459f-a20f-e24d2343fe5f' as uniqueidentifier), CAST('522FFA4D-D907-43E2-BB23-96FA7FEF24B1' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Yes'),
(CAST('3777c617-2946-46af-8f72-fec8e6840c15' as uniqueidentifier), CAST('600FA0C8-D3DE-4C78-9E2E-0B79D2A794F1' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Wi-Fi 802.11 a/b/g/n/ac/6e, dual-band, Wi-Fi Direct'),
(CAST('6963bfdf-5744-4143-bc9c-96c5c12a71c1' as uniqueidentifier), CAST('C3F8CD5F-168D-4F4D-ADA3-1344CB7E75E7' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'GPS, GLONASS, BDS, GALILEO'),
(CAST('0d6cbb25-2327-4271-9c83-1860d4bc4f3e' as uniqueidentifier), CAST('52832EB3-A80E-4828-B0EC-19B458FE1DF7' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Yes'),
(CAST('bbe15c3b-e7f8-4c68-bdae-49014deffceb' as uniqueidentifier), CAST('409F8969-4650-4B2F-94F0-A5BDFF20CA0C' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Yes'),
(CAST('89831729-7778-4bd4-babc-b402c1f54d61' as uniqueidentifier), CAST('11D6F0D6-D9BC-4B33-897A-BC66E6B8BF5D' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'No'),
(CAST('2bf0c423-25b2-413d-9e40-79d1b8a3c6c6' as uniqueidentifier), CAST('F60DA4E8-2D75-4A5D-B6D1-EAD215939720' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'No'),
(CAST('6e5f26a3-5c24-4c71-a681-646fb63069c5' as uniqueidentifier), CAST('99E02E27-604B-4487-A6EE-FEF0DFD90051' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Yes'),

(CAST('5eb258f8-f42d-4268-9869-abdb9943b459' as uniqueidentifier), CAST('80BBADDC-4D0A-44C7-BCE0-041BA78139F9' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 'Li-Ion 5000 mAh, non-removable'),
(CAST('e6434c4c-5195-42af-94b7-77d7def0e05b' as uniqueidentifier), CAST('7B314B22-4695-4140-9861-E44D08624052' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), '45W wired, PD3.0')

GO

INSERT INTO ProductLinks(Id, ProductId, LinkedProductId, LinkType) VALUES
(CAST('207fd35e-3e05-4861-9dee-80be435b3bdf' as uniqueidentifier), CAST('1761d0be-6a7d-49c2-bb97-d40cea3eb8d5' as uniqueidentifier), CAST('8c1acba8-0487-47fe-9491-e8334dc94d23' as uniqueidentifier), 1)

GO
