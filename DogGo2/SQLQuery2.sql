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
