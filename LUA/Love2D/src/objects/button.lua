local OBJECT = Class("Button")

function OBJECT:initialize()
    self.pos = {["x"] = 0, ["y"] = 0}
    self.size = {["w"] = 100, ["h"] = 100}
    self.color = {1, 1, 1, 1}

    self.textPos = {["x"] = 0, ["y"] = 0}
    self.textColor = {0, 0, 0, 1}

    self.text = "Click Me!"
    self.font = love.graphics.newFont("assets/trebuchet.ttf", 12)
    self.textObj = love.graphics.newText(self.font, self.text)

    self.isClicked = false
    self.isHovered = false

    self:UpdateTextPosition()
end

function OBJECT:IsHovered()
    return self.isHovered
end

function OBJECT:IsClicked()
    return self.isClicked
end

function OBJECT:IsMouseInArea(x, y)
    return self.pos.x < x and self.pos.y < y and self.pos.x + self.size.w > x and self.pos.y + self.size.h > y
end

function OBJECT:UpdateTextPosition()
    local center = self:GetCenter()
    self.textPos.x, self.textPos.y = center[1], center[2]
    self.textPos.x = self.textPos.x - (self.textObj:getWidth() / 2)
    self.textPos.y = self.textPos.y - (self.textObj:getHeight() / 2)
    self.textPos.x, self.textPos.y = self.textPos.x - self.pos.x, self.textPos.y - self.pos.y
end

function OBJECT:GetCenter()
    return {self.pos.x + (self.size.w / 2), self.pos.y + (self.size.h / 2)}
end

function OBJECT:SetLayer(layer)
    self.layer = layer
end

function OBJECT:GetLayer()
    return self.layer
end

function OBJECT:SetPos(x, y)
    self.pos.x, self.pos.y = x, y
    self:UpdateTextPosition()
end

function OBJECT:GetPos()
    return self.pos
end

function OBJECT:SetSize(w, h)
    self.size.w, self.size.h = w, h
    self:UpdateTextPosition()
end

function OBJECT:GetSize()
    return self.size
end

function OBJECT:SetText(text)
    self.text = text
    self.textObj:set(text)
    self:UpdateTextPosition()
end

function OBJECT:SetFont(font)
    self.textObj:setFont(font)
    self:UpdateTextPosition()
end

function OBJECT:SetColor(color)
    self.color = color
end

function OBJECT:SetTextColor(color)
    self.textColor = color
end

function OBJECT:Draw()
    -- Draw button box
    love.graphics.setColor(unpack(self.color))
    love.graphics.rectangle("fill", self.pos.x, self.pos.y, self.size.w, self.size.h)

    -- Draw text
    love.graphics.setColor(unpack(self.textColor))
    love.graphics.draw(self.textObj, self.pos.x + self.textPos.x, self.pos.y + self.textPos.y)
end

-- Button events
function OBJECT:OnHovered() end
function OBJECT:OffHovered() end
function OBJECT:OnClicked() end
function OBJECT:OffClicked() end
function OBJECT:DoClick() end

return OBJECT
