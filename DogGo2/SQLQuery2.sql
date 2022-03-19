SELECT *
FROM Owner

SELECT w.NeighborhoodId
FROM Walker w
LEFT JOIN Neighborhood N on w.NeighborhoodId = N.Id

SELECT w.Id, w.[Name], w.ImageUrl, w.NeighborhoodId, n.[Name] AS Neighborhood
FROM Walker w
LEFT JOIN Neighborhood n on w.NeighborhoodId = n.id

SELECT *
FROM Walker , Neighborhood
WHERE Walker.NeighborhoodId = Neighborhood.Id

SELECT m.[Name] as HoodName, 
       w.[Name] as WalkerName,
       w.Id,
       w.ImageUrl,
       w.NeighborhoodId
FROM Neighborhood m
LEFT JOIN Walker w ON w.NeighborhoodId = m.Id


INSERT INTO Owner ([Name], Email, Phone, Address, NeighborhoodId)
OUTPUT INSERTED.ID
VALUES ('Gabriel', 'test@test.com', '6156151615', '123 test street', 1);

SELECT *
FROM Owner


UPDATE Owner
SET 
     [Name] = 'Gabriel Smith', 
     Email = 'newtest@test.com', 
     [Address] = 'test 2 street', 
     Phone = '615615615', 
     NeighborhoodId = 1
WHERE Id = 9;

DELETE FROM Owner
WHERE Id = 10;

SELECT *
FROM Dog;

SELECT Id, [Name], OwnerId, Breed, Notes, ImageUrl
FROM Dog;

                        SELECT [Date], Duration, WalkerId, DogId
                        FROM Walks
                        WHERE WalkerId = 1 AND DogId = 1

