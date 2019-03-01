_G.factors = {
    3,
    5
}

_G.factorWords = {
    "Fizz",
    "Buzz"
}

_G.Class = require("src.vendor.middleClass")

local ButtonClass = require("src.objects.button")

local buttons = {}

function love.load()
    local testButton = ButtonClass()
    table.insert(buttons, testButton)
end

function love.update(dt)

end

function love.draw()
    for _, button in pairs(buttons) do
        button:Draw()
    end
end

function love.keypressed(key, scanCode, isRepeat)

end

function love.keyreleased(key, scanCode)

end

function love.mousemoved(x, y, dx, dy, isTouch)
    local currentTarget = nil

    for buttonIndex, button in pairs(buttons) do
        if button:IsMouseInArea(x, y) then
            if currentTarget == nil then
               currentTarget = button
            else
                if button:GetLayer() > currentTarget:GetLayer() then
                    currentTarget = button
                end
            end
        else
            if button:IsHovered() and not button:IsClicked() then
                button.isHovered = false
                button:OffHovered()
            end
        end
    end

    if currentTarget and not currentTarget:IsHovered() and not currentTarget:IsClicked() then
        currentTarget.isHovered = true
        currentTarget:OnHovered(x, y, dx, dy, isTouch)
    end
end

function love.mousepressed(x, y, button, isTouch, presses)
    local currentTarget = nil

    for buttonId, button in pairs(buttons) do
        if button:IsMouseInArea(x, y) then
            if currentTarget == nil then
               currentTarget = button
            else
                if button:GetLayer() > currentTarget:GetLayer() then
                    currentTarget = button
                end
            end
        end
    end

    if currentTarget then
        if currentTarget:IsHovered() then
            currentTarget.isHovered = false
            currentTarget:OffHovered()
        end
        currentTarget.isClicked = true
        currentTarget:OnClicked(x, y, dx, dy, isTouch)
    end
end

function love.mousereleased(x, y, button, isTouch, presses)
    local currentTarget = nil

    for buttonId, button in pairs(buttons) do
        if button:IsMouseInArea(x, y) then
            if currentTarget == nil then
               currentTarget = button
            else
                if button:GetLayer() > currentTarget:GetLayer() then
                    currentTarget = button
                end
            end
        else
            if button:IsClicked() then
                button.isClicked = false
                button:OffClicked()
            end
        end
    end

    if currentTarget and currentTarget:IsClicked() then
        currentTarget.isClicked = false
        currentTarget:OffClicked(x, y, dx, dy, isTouch)
        currentTarget:DoClick(x, y, dx, dy, isTouch)
    end
end

function love.wheelmoved(x, y)

end
