export class CommentView {
    id : number
    createdById : string
    text: string
    authorName: string
    authorImageUrl: string
    createdDateUtc: Date
    isEdited: boolean
    replies: CommentView[]
    answeredCommentId: number
}
