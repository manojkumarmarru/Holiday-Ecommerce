
-- Insert data into Users table
INSERT INTO Users (userId, name, emailId, contactNo, password, bookings) VALUES
('U1001', 'abc', 'abc@gmail.com', 9098765432, 'Abc@1234', '["B1001","B1002"]'),
('U1002', 'def', 'def@gmail.com', 1234567890, 'Def@1234', '["B1003"]');

-- Insert data into Bookings table
INSERT INTO Bookings (bookingId, userId, destId, destinationName, checkInDate, checkOutDate, noOfPersons, totalCharges, timeStamp) VALUES
('B1001', 'U1001', 'HD1001', 'A Week in Greece: Athens, Mykonos & Santorini', '2018-12-09', '2018-12-16', 2, 5998, CAST(GETDATE() AS NVARCHAR)),
('B1002', 'U1001', 'D1002', 'Romantic Europe: Paris, Venice & Vienna', '2019-01-10', '2019-01-24', 1, 4549, CAST(GETDATE() AS NVARCHAR)),
('B1003', 'U1002', 'D1002', 'Romantic Europe: Paris, Venice & Vienna', '2019-01-10', '2019-01-24', 1, 4549, CAST(GETDATE() AS NVARCHAR));

-- Insert data into Destinations table
INSERT INTO Destinations (destinationId, continent, imageUrl, name, description, noOfNights, flightCharges, chargesPerPerson, discount, availability) VALUES
('D1001', 'Europe', '/assets/geece.jpg', 'A Week in Greece: Athens, Mykonos & Santorini', 'Watch the setting sun from the hilltops of Greece''s most famous islands. Experience ancient history and open-air museums in the capital of Athens. Then, the quintessential, beautiful Greek islands you''ve been dreaming of come to life on the isles of Mykonos and Santorini.', 7.0, 500, 2499.0, 0.0, 30),
('D1002', 'Europe', '/assets/romantic.jpg', 'Romantic Europe: Paris, Venice & Vienna', 'Get swept away by the beauty of Europe''s most romantic cities. Journey through the dazzling imperial capitals of France, Italy, Slovenia, and Austria, soaking up each destination''s unique culture along the way. Sip coffee in charming cafes, spend your days exploring the grand boulevards or admiring sparkling canals, and watch each city''s skyline light up every evening.', 10.0, 500, 2729.0, 0.0, 30),
('D1003', 'Europe', '/assets/europe.jpg', 'Jewels of Alpine Europe', 'Experience rich culture against a backdrop of soaring Alpine peaks. Journey from Switzerland''s mountain-lined Lake Lucerne to France''s inspiring Lake Annecy. Take in the picturesque Chamonix Valley and stroll along Italy''s Lake Como. Then, cross Liechtenstein and hit the winter wonderland of Innsbruck before heading to Munich, the lively capital of Bavaria.', 11.0, 500, 2799.0, 0.0, 30),
('D1004', 'Europe', '/assets/easteurope.jpg', 'Highlights of Eastern Europe', 'Experience Eastern Europe in all its complexity. Imperial palaces, World War II sites, vibrant cafes—you can find it all in Eastern Europe. Journey along the Danube from the two-sided city of Budapest to Vienna, unrivaled for its beauty and majesty. Then, visit the castles and cathedrals of Prague and explore medieval Kraków before ending in modern Warsaw.', 13.0, 500, 2699.0, 0.0, 30),
('D1005', 'Europe', '/assets/rome.jpg', 'London, Paris & Rome', 'Delve deep into the history and culture of three inspiring, influential cities. Perhaps no cities have influenced the world more over the last 2,000 years than London, Paris, and Rome. On this guided tour, iconic sights like Big Ben, the Eiffel Tower, and the Colosseum are just the beginning of what you''ll see. Take it all in as you embark on this sweeping trip through England, France, and Italy.', 13.0, 500, 2699.0, 0.0, 30),
('D1006', 'Australia', '/assets/aus1.jpg', 'Grand Tour of Australia', 'An island, a country, and a continent all in one. Experience the allure of the Land Down Under when you snorkel above the Great Barrier Reef, gaze at Uluru, and explore the Sydney Opera House. From multicultural Melbourne to the vast Outback, Australia is full of surprises for you to discover.', 14.0, 500, 4549.0, 0.0, 30),
('D1007', 'Australia', '/assets/aus2.jpg', 'Australia & New Zealand', 'Australia and New Zealand—a world away. From Australia''s Great Barrier Reef and the rugged Outback to New Zealand''s sheep-dotted plains and cliff-lined fjords, the South Pacific features a lineup of dramatic landscapes. In-between outdoor adventures, you''ll discover sophisticated, multicultural cities and an irresistible, carpe diem spirit on this tour.', 22.0, 500, 6399.0, 0.0, 30),
('D1008', 'Asia', '/assets/china.jpg', 'China: Beijing, the Yangtze & Shanghai', 'Experience China and all of its contrasts. China''s sheer size is impossible to fathom until you walk across the expanse of Tiananmen Square or gaze at the seemingly endless Great Wall. Take a leisurely cruise down the Yangtze River and ride the world''s fastest train. Discover this magnificent country, from pristine landscapes and towering cityscapes to ancient sites and modern marvels.', 13.0, 500, 2399.0, 0.0, 30),
('D1009', 'Asia', '/assets/wine.jpg', 'Food & Wine: Uruguay, Argentina & Chile', 'Toast to the South American flavors of these three unique countries. The people of Uruguay, Argentina, and Chile each offer a unique take on the art of cooking and winemaking. Learn about the traditional side of wine production at a family-run bodega outside of Montevideo. Soak in the flavors—and the views—at a sophisticated wine estate in Mendoza. Stop for a sip in the acclaimed Aconcagua Valley wine region. Whether you''re visiting a small village or an expansive market, you''ll discover how locals celebrate their country''s tasty traditions on this culinary adventure.', 8.0, 500, 3549.0, 0.0, 30),
('D1010', 'Asia', '/assets/singapore.jpg', 'Singapore & Malaysia: A Journey through Southeast Asia', 'Discover the mystique of Singapore and Malaysia. Travel from bustling city streets to pristine shorelines, taking in some of Southeast Asia''s most interesting cultures along the way. Stand in awe of Singapore''s world-class amenities and futuristic innovation before retreating into nature in Borneo, where dense jungles harbor impressive animal life. Round out your trip in cosmopolitan Kuala Lumpur to see how deep-rooted traditions intersect with the present-day.', 9.0, 500, 2649.0, 0.0, 30),
('D1011', 'Asia', '/assets/tokyo.jpg', 'Highlights of Japan: Tokyo to Kyoto', 'Discover how centuries-old traditions coexist with cutting-edge culture. The traditional Japanese tea ceremony is the embodiment of Japanese hospitality, representing harmony, respect, purity, and tranquility. You''ll experience this Zen aesthetic every day of your Japanese tour—and not only while drinking tea. Uncover ancient temples alongside futuristic cityscapes and witness how Japan''s art, architecture, and day-to-day culture continue to reflect its time-honored philosophies.', 8.0, 500, 3349.0, 0.0, 30);

-- Insert data into Hotdeals table
INSERT INTO Hotdeals (destinationId, continent, name, imageUrl, noOfNights, flightCharges, chargesPerPerson, discount, availability) VALUES
('HD1001', 'Asia', 'Thailand : The Golden Kingdom', '/assets/Thailand.jpg', 11.0, 400, 2249.0, 5.0, 15),
('HD1002', 'Australia', 'Australia & New Zealand', '/assets/aus3.jpg', 19.0, 400, 6399.0, 5.0, 15),
('HD1003', 'Europe', 'Budapest, Vienna & Prague', '/assets/prague.jpg', 9.0, 400, 2049.0, 5.0, 15);