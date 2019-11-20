export class LiqPayResponseModel{
    constructor(
    public projectId: number,
    public amount: number,
    public status: string,
    public orderId: string
    ){}
}