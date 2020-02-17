export class NewsDetails {
    id: number
    title: string
    text: string
    mainImageUrl : string
    contentImageUrls: string[]
    authorName: string
    createdDateUtc : Date
    likesCount: number
}